using System;
using System.Text;

class EncryptDecryptText
{
    static string Encrypt(string text, string key)
    {
        StringBuilder encrypted = new StringBuilder(text.Length);
        for (int i = 0; i < text.Length; i++)
        {
            encrypted.Append((char)(text[i] ^ key[i % key.Length]));
        }
        return encrypted.ToString();
    }

    static string Decrypt(string text, string key)
    {
        return Encrypt(text, key).ToString();
    }

    static void Main()
    {
        string text = "Some text for crypting and decrypting!";
        string key = "Decryption key";
        string encryptedText = Encrypt(text, key);
        string decryptedText = Decrypt(encryptedText, key);

        Console.WriteLine("Encrypted text -> {0}", encryptedText);
        
        Console.WriteLine("Decrypted text -> {0}", decryptedText);
    }
}
