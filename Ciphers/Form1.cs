using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Ciphers
{
    public partial class Form1 : Form
    {

        public static string transDesc = "Переворачивает каждое введённое вами слово задом наперёд";
        public static string cesarDesc = "Сдвиг влево или направо на N позиций в алфавите";
        public static string binaryDesc = "Преобразовывает ваш текст в набор из 0 и 1";
        public static string atbashDesc = "Кодирует с перевернутым алфавитом";
        public static string swordDesc = "Выбирается кодовое слово, которое пишется впереди, затем выписываются остальные буквы алфавита в своем порядке";
        public static string a1z26Desc = "Каждая буква заменяется порядковым номером в алфавите";

        public static string alEn = "abcdefghijklmnopqrstuvwxyz";
        public static string alRu = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";

        public static string alEnAtbash = "zyxwvutsrqponmlkjihgfedcba";
        public static string alRuAtbash = "яюэьыъщшчцхфутсрпонмлкйизжёедгвба";

        public static Cipher current = Cipher.TRANS;

        public enum Cipher { TRANS, CESAR, BINARY, ATBASH, SWORD, A1Z26 };

        public Form1() {
            InitializeComponent();
        }

        private string stringToA1Z26(string s) {

            try
            {
                string alphabet = null;

                if (comboBoxSWordAlphabet.Text.ToLower() == "русский")
                {

                    alphabet = alRu;

                }
                else { alphabet = alEn; }

                StringBuilder sb = new StringBuilder();
                bool wording = false;

                for (int i = 0; i < s.Length; i++)
                {
                    int h = has(s[i], alphabet);
                    int notreal = h + 1;

                    if (!wording && h != -1) {

                        wording = true;
                        sb.Append(notreal);
                        continue;

                    } else if (wording) {

                        if (h != -1)
                        {

                            sb.Append("-" + notreal);
                            continue;

                        }
                        else {

                            wording = false;

                        }

                    }

                    sb.Append(s[i]);

                }

                return sb.ToString();

            }
            catch (Exception ignored) {}

            return s;

        }

        private int has(char s, string alphabet) {
            s = Char.ToLower(s);

            for (int i = 0; i < alphabet.Length; i++) {

                if (s == alphabet[i]) {

                    return i;

                }

            }

            return -1;

        }

        private string A1Z26ToString(string s) {

            try
            {
                string alphabet = null;

                if (comboBoxSWordAlphabet.Text.ToLower() == "русский")
                {

                    alphabet = alRu;

                }
                else { alphabet = alEn; }

                StringBuilder sb = new StringBuilder();
                int? temp = null;
                bool digiting = false;

                for (int i = 0; i < s.Length; i++)
                {

                    if (!digiting && Char.IsDigit(s[i])) {

                        if (temp == null) {

                            temp = Convert.ToInt32(s[i].ToString());

                        } else Convert.ToInt32("" + ((int)temp).ToString() + s[i].ToString());

                        digiting = true;
                        continue;

                    } else if (digiting) {

                        if (Char.IsDigit(s[i]))
                        {

                            if (temp == null)
                            {

                                temp = Convert.ToInt32(s[i].ToString());

                            }
                            else temp = Convert.ToInt32("" + ((int)temp).ToString() + s[i].ToString());
                            continue;

                        }
                        else {

                            if (temp - 1 <= alphabet.Length - 1) {

                                sb.Append(alphabet[(int) temp - 1]);

                            }
                            temp = null;
                            digiting = false;
                           

                        }

                    }

                    if (!(s[i] == '-' && ((i + 1 <= s.Length - 1 && Char.IsDigit(s[i + 1])) || (i - 1 <= s.Length - 1 && Char.IsDigit(s[i - 1]))))) {

                        sb.Append(s[i]);

                    }

                }

                if (digiting && temp != null) {

                    if (temp - 1 <= alphabet.Length - 1)
                    {

                        sb.Append(alphabet[(int)temp - 1]);

                    }
                    temp = null;

                }

                return sb.ToString();

            }
            catch (Exception ignored) { }

            return s;

        }

        private string getAlphabetWithWord(string alphabet, string word) {
            string clone = alphabet;

            for (int i = 0; i < word.Length; i++){

                for (int j = 0; j < alphabet.Length; j++)
                {
                    char lower = Char.ToLower(word[i]);
                    if (lower == alphabet[j])
                    {
                        int element = -1;
                        for (int g = 0; g < clone.Length; g++)
                        {

                            if (lower == clone[g])
                            {

                                element = g;
                                break;

                            }

                        }

                        if (element != -1) {

                            if (clone.Length == element + 1) {

                                clone = clone.Remove(element);

                            }else clone = clone.Remove(element, 1);

                        }

                    }

                }

            }

            clone = word.ToLower() + clone;

            return clone;
        }

        private string stringToSWord(string text) {
            try
            {
                string alphabet = null;

                if (comboBoxSWordAlphabet.Text.ToLower() == "русский")
                {

                    alphabet = alRu;

                }
                else { alphabet = alEn; }

                string withword = getAlphabetWithWord(alphabet, textBoxSWordWord.Text);

                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < text.Length; i++)
                {
                    bool was = false;
                    for (int j = 0; j < alphabet.Length; j++)
                    {
                        if (Char.ToLower(text[i]) == alphabet[j])
                        {

                            if (Char.IsUpper(text[i]))
                            {

                                sb.Append(Char.ToUpper(withword[j]));

                            }
                            else sb.Append(withword[j]);

                            was = true;
                            break;
                        }
                    }

                    if (was) continue;

                    sb.Append(text[i]);

                }

                return sb.ToString();
            }catch (Exception e) { }

            return null;
        }

        private string swordToString(string text) {

            try
            {

                string alphabet = null;

                if (comboBoxSWordAlphabet.Text.ToLower() == "русский")
                {

                    alphabet = alRu;

                }
                else { alphabet = alEn; }

                string withword = getAlphabetWithWord(alphabet, textBoxSWordWord.Text);

                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < text.Length; i++)
                {
                    bool was = false;

                    for (int j = 0; j < withword.Length; j++)
                    {
                        if (Char.ToLower(text[i]) == withword[j])
                        {

                            if (Char.IsUpper(text[i]))
                            {

                                sb.Append(Char.ToUpper(alphabet[j]));

                            }
                            else sb.Append(alphabet[j]);

                            was = true;
                            break;
                        }
                    }

                    if (was) continue;

                    sb.Append(text[i]);

                }

                return sb.ToString();

            }
            catch (Exception e) { }

            return null;
        }

        private static string stringToAtbash(string text) {
            try
            {
                StringBuilder sb = new StringBuilder();

                for (int i = 0; i < text.Length; i++)
                {
                    bool was = false;
                    for (int j = 0; j < alRu.Length; j++)
                    {
                        if (Char.ToLower(text[i]) == alRu[j])
                        {
                            if (Char.IsUpper(text[i]))
                            {

                                sb.Append(Char.ToUpper(alRuAtbash[j]));

                            }
                            else sb.Append(alRuAtbash[j]);

                            was = true;
                            break;

                        }
                    }

                    if (was) continue;

                    for (int j = 0; j < alEn.Length; j++)
                    {
                        if (Char.ToLower(text[i]) == alEn[j])
                        {

                            if (Char.IsUpper(text[i]))
                            {

                                sb.Append(Char.ToUpper(alEnAtbash[j]));

                            }
                            else sb.Append(alEnAtbash[j]);


                            was = true;
                            break;

                        }
                    }

                    if (was) continue;

                    sb.Append(text[i]);

                }

                return sb.ToString();
            }
            catch (Exception e) { }

            return null;
        }

        private static string atbashToString(string text)
        {
            try
            {
                StringBuilder sb = new StringBuilder();

                for (int i = 0; i < text.Length; i++)
                {
                    bool was = false;
                    for (int j = 0; j < alRuAtbash.Length; j++)
                    {
                        if (Char.ToLower(text[i]) == alRuAtbash[j])
                        {
                            if (Char.IsUpper(text[i]))
                            {

                                sb.Append(Char.ToUpper(alRu[j]));

                            }
                            else sb.Append(alRu[j]);

                            was = true;
                            break;

                        }
                    }

                    if (was) continue;

                    for (int j = 0; j < alEnAtbash.Length; j++)
                    {
                        if (Char.ToLower(text[i]) == alEnAtbash[j])
                        {

                            if (Char.IsUpper(text[i]))
                            {

                                sb.Append(Char.ToUpper(alEn[j]));

                            }
                            else sb.Append(alEn[j]);


                            was = true;
                            break;

                        }
                    }

                    if (was) continue;

                    sb.Append(text[i]);

                }

                return sb.ToString();
            }
            catch (Exception e) { }

            return null;
        }

        private static string stringToCesar(string text, int shift)
        {
            try
            {
                string s1 = "";

                for (int i = 0; i < text.Length; i++)
                {
                    Boolean was = false;
                    for (int j = 0; j < alRu.Length; j++)
                    {

                        if (Char.ToLower(text[i]) == alRu[j])
                        {

                            int shiftclone = shift;
                            int temp = j;
                            while (shiftclone != 0)
                            {

                                if (shiftclone < 0)
                                {

                                    temp -= 1;
                                    shiftclone += 1;

                                    if (temp < 0)
                                    {

                                        temp = alRu.Length - 1;

                                    }

                                }
                                else if (shiftclone > 0)
                                {

                                    temp += 1;
                                    shiftclone -= 1;

                                    if (temp > alRu.Length - 1)
                                    {

                                        temp = 0;

                                    }

                                }

                            }

                            if (Char.IsUpper(text[i]))
                                {

                                    s1 += Char.ToUpper(alRu[temp]);

                                }
                                else s1 += alRu[temp];
                            was = true;
                            break;

                            }
                    }

                    if (was) continue;

                    for (int j = 0; j < alEn.Length; j++){
                        if (Char.ToLower(text[i]) == alEn[j]){

                        int shiftclone = shift;
                        int temp = j;
                        while (shiftclone != 0) {

                            if (shiftclone < 0) {

                                temp -= 1;
                                shiftclone += 1;

                                    if (temp < 0)
                                    {

                                        temp = alEn.Length - 1;

                                    }

                                } else if (shiftclone > 0) {

                                temp += 1;
                                shiftclone -= 1;

                                    if (temp > alEn.Length - 1)
                                    {

                                        temp = 0;

                                    }

                                }

                        }

                            if (Char.IsUpper(text[i]))
                            {

                                s1 += Char.ToUpper(alEn[temp]);

                            }
                            else s1 += alEn[temp];


                            was = true;
                        break;

                        }
                    }

                    if (was) continue;

                    s1 += text[i];

                }

                return s1;
            }
            catch (Exception e) { }

            return null;
        }

        private static string cesarToString(string text, int shift)
        {
            return stringToCesar(text, shift * -1);
        }

        public void switchCipher(Cipher n){

            if (current == Cipher.TRANS)
            {

                switchTrans.Enabled = true;

            }
            else if (current == Cipher.CESAR)
            {

                switchCesar.Enabled = true;

                labelCesarTo.Visible = false;
                radioRight.Visible = false;
                radioLeft.Visible = false;
                labelCesarOn.Visible = false;
                numericCesar.Visible = false;
                labelCesarPositions.Visible = false;

            }
            else if (current == Cipher.BINARY)
            {

                switchBinary.Enabled = true;

            }
            else if (current == Cipher.ATBASH)
            {

                switchAtbash.Enabled = true;

            }
            else if (current == Cipher.SWORD)
            {

                switchSWord.Enabled = true;
                labelSWordWord.Visible = false;
                labelSWordAlphabet.Visible = false;
                comboBoxSWordAlphabet.Visible = false;
                textBoxSWordWord.Visible = false;

            } else if (current == Cipher.A1Z26) {

                switchA1Z26.Enabled = true;
                labelSWordAlphabet.Visible = false;
                comboBoxSWordAlphabet.Visible = false;

            }

            current = n;

            if (n == Cipher.TRANS) {

                switchTrans.Enabled = false;
                cipherName.Text = switchTrans.Text;
                description.Text = transDesc;

            } else if (n == Cipher.CESAR) {

                switchCesar.Enabled = false;
                cipherName.Text = switchCesar.Text;
                description.Text = cesarDesc;

                labelCesarTo.Visible = true;
                radioRight.Visible = true;
                radioLeft.Visible = true;
                labelCesarOn.Visible = true;
                numericCesar.Visible = true;
                labelCesarPositions.Visible = true;

            } else if (n == Cipher.BINARY) {

                switchBinary.Enabled = false;
                cipherName.Text = switchBinary.Text;
                description.Text = binaryDesc;

            }else if (n == Cipher.ATBASH)
            {

                switchAtbash.Enabled = false;
                cipherName.Text = switchAtbash.Text;
                description.Text = atbashDesc;

            }
            else if (n == Cipher.SWORD)
            {

                switchSWord.Enabled = false;
                cipherName.Text = switchSWord.Text;
                description.Text = swordDesc;

                labelSWordWord.Visible = true;
                labelSWordAlphabet.Visible = true;
                comboBoxSWordAlphabet.Visible = true;
                textBoxSWordWord.Visible = true;

            }
            else if (n == Cipher.A1Z26)
            {

                switchA1Z26.Enabled = false;
                cipherName.Text = switchA1Z26.Text;
                description.Text = a1z26Desc;

                labelSWordAlphabet.Visible = true;
                comboBoxSWordAlphabet.Visible = true;

            }

            inputBox.Text = "";
            outputBox.Text = "";

        }

        public static string stringToTrans(string data) {
            StringBuilder sb = new StringBuilder();
            string[] split = data.Split(' ');

            int i = 0;
            foreach (string s in split) {
                i++;
            
                string ss = s;
                while (true) {

                    if (ss.Length == 0)
                    {

                        break;

                    }

                    sb.Append(ss.Last());
                    ss = ss.Remove(ss.Length - 1);

                }

                if (i != split.Length) {

                    sb.Append(ss + " ");

                }

            }

            return sb.ToString();
        }

        public static string transToString(string data)
        {
            StringBuilder sb = new StringBuilder();
            string[] split = data.Split(' ');

            int i = 0;
            foreach (string s in split)
            {
                i++;

                string ss = s;
                while (true)
                {

                    if (ss.Length == 0)
                    {

                        break;

                    }

                    sb.Append(ss.Last());
                    ss = ss.Remove(ss.Length - 1);

                }

                if (i != split.Length)
                {

                    sb.Append(ss + " ");

                }

            }

            return sb.ToString();
        }

        public static string stringToBinary(string data){
            try
            {
                data = data.Replace(" ", "");
                Byte[] bytes = Encoding.UTF8.GetBytes(data.ToCharArray());
                StringBuilder sb = new StringBuilder();

                foreach (Byte b in bytes) {

                    sb.Append(Convert.ToString(b, 2));

                }

                return sb.ToString();
            }
            catch (Exception e) { }

            return null;
        }

        public static Byte[] GetBytesFromBinaryString(String binary)
        {
            var list = new List<Byte>();

            for (int i = 0; i < binary.Length; i += 8)
            {
                String t = binary.Substring(i, 8);

                list.Add(Convert.ToByte(t, 2));
            }

            return list.ToArray();
        }

        public static string binaryToString(string data){
            try
            {
                Byte[] byteList = GetBytesFromBinaryString(data);

                return Encoding.UTF8.GetString(byteList.ToArray());
            }
            catch (Exception e) {  }

            return null;
        }

        private void switchCesar_Click(object sender, EventArgs e){
            switchCipher(Cipher.CESAR);
        }

        private void switchBinary_Click(object sender, EventArgs e){
            switchCipher(Cipher.BINARY);
        }

        private void switchTrans_Click(object sender, EventArgs e){
            switchCipher(Cipher.TRANS);
        }

        private void switchAtbash_Click(object sender, EventArgs e)
        {
            switchCipher(Cipher.ATBASH);
        }

        private void switchSWord_Click(object sender, EventArgs e)
        {
            switchCipher(Cipher.SWORD);
        }

        private void inputBox_TextChanged(object sender, EventArgs e){

            if (!inputBox.Focused) {

                return;

            }

            String s = null;
            if (current == Cipher.TRANS) {

                s = stringToTrans(inputBox.Text);

            }
            else if (current == Cipher.CESAR)
            {

                int shift = Decimal.ToInt32(numericCesar.Value);

                if (radioLeft.Checked)
                {

                    shift *= -1;

                }

                s = stringToCesar(inputBox.Text, shift);

            }
            else if (current == Cipher.BINARY) {


                s = stringToBinary(inputBox.Text);

            }
            else if (current == Cipher.ATBASH)
            {

                s = stringToAtbash(inputBox.Text);

            }
            else if (current == Cipher.SWORD)
            {

                s = stringToSWord(inputBox.Text);

            } else if (current == Cipher.A1Z26) {

                s = stringToA1Z26(inputBox.Text);

            }

            if (s != null) {

                outputBox.Text = s;

            }

        }

        private void outputBox_TextChanged(object sender, EventArgs e){

            if (!outputBox.Focused){

                return;

            }

            String s = null;
            if (current == Cipher.TRANS)
            {

                s = transToString(outputBox.Text);

            }
            else if (current == Cipher.CESAR)
            {

                int shift = Decimal.ToInt32(numericCesar.Value);

                if (radioLeft.Checked) {

                    shift *= -1;

                }

                s = cesarToString(outputBox.Text, shift);

            }
            else if (current == Cipher.BINARY){

                s = binaryToString(outputBox.Text);

            }
            else if (current == Cipher.ATBASH)
            {

                s = atbashToString(outputBox.Text);

            }
            else if (current == Cipher.SWORD)
            {

                s = swordToString(outputBox.Text);

            }
            else if (current == Cipher.A1Z26)
            {

                s = A1Z26ToString(outputBox.Text);

            }

            if (s != null)
            {

                inputBox.Text = s;

            }

        }

        private void numericCesar_ValueChanged(object sender, EventArgs e)
        {

            int shift = Decimal.ToInt32(numericCesar.Value);

            if (radioLeft.Checked)
            {

                shift *= -1;

            }

            string s = stringToCesar(inputBox.Text, shift);

            if (s != null)
            {

                outputBox.Text = s;

            }

        }

        private void radioRight_CheckedChanged(object sender, EventArgs e)
        {

            int shift = Decimal.ToInt32(numericCesar.Value);

            if (radioLeft.Checked)
            {

                shift *= -1;

            }

            string s = stringToCesar(inputBox.Text, shift);

            if (s != null)
            {

                outputBox.Text = s;

            }

        }

        private void radioLeft_CheckedChanged(object sender, EventArgs e)
        {
            int shift = Decimal.ToInt32(numericCesar.Value);

            if (radioLeft.Checked)
            {

                shift *= -1;

            }

            string s = stringToCesar(inputBox.Text, shift);

            if (s != null)
            {

                outputBox.Text = s;

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxSWordAlphabet.SelectedIndex = 0;
        }

        private void comboBoxSWordAlphabet_SelectedIndexChanged(object sender, EventArgs e)
        {

            string s;
            if (current == Cipher.SWORD) {

                s = stringToSWord(inputBox.Text);

            }else s = stringToA1Z26(inputBox.Text);

            if (s != null) {

                outputBox.Text = s;

            }

        }

        private void textBoxSWordWord_TextChanged(object sender, EventArgs e)
        {
            string s = stringToSWord(inputBox.Text);

            if (s != null)
            {

                outputBox.Text = s;

            }
        }

        private void switchA1Z26_Click(object sender, EventArgs e)
        {
            switchCipher(Cipher.A1Z26);
        }

    }
}
