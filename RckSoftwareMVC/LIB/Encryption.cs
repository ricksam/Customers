using System;
using System.Collections.Generic;
using System.Text;
using System.Security.Cryptography;

namespace lib.Class
{
    /*
    public class Encryption
  {
    #region Constructor
    public Encryption(string Key) 
    {
      this.Key = Encryption.GetSHA1(Key);
      Cnv = new Conversion();
      Chars = " !\"#$%&'()*+,-./0123456789:;<=>?@ABCDEFGHIJKLMNOPQRSTUVWXYZ[\\]^_`abcdefghijklmnopqrstuvwxyz{|}~¡¢£¤¥¦§¨©ª«¬­®¯°±²³´µ¶·¸¹º»¼½¾¿ÀÁÂÃÄÅÆÇÈÉÊËÌÍÎÏÐÑÒÓÔÕÖ×ØÙÚÛÜÝÞßàáâãäåæçèéêëìíîïðñòóôõö÷øùúûüý";
    }
    #endregion

    #region Constructor
    public Encryption(string Key, string CharacterMap)
    {
      this.Key = Encryption.GetSHA1(Key);
      Cnv = new Conversion();
      Chars = CharacterMap;
    }
    #endregion

    #region Fields
    private string Key { get; set; }
    private Conversion Cnv { get; set; }
    public string Chars { get; set; }
    #endregion

    #region Methods
    #region private int getIdxChar(char c)
    private int getIdxChar(char c) 
    {
      for (int i = 0; i < Chars.Length; i++)
      {
        if (c == Chars[i])
        { return i; }
      }
      return -1;
    }
    #endregion

    #region private string EncriptyASCII(string text, bool use_even, int char_min, int char_max)
    /// <summary>
    /// Motor de criptografia para caracteres
    /// </summary>
    /// <param name="text">Texto a ser criptografado</param>
    /// <param name="use_even">usar retorno da posição impar ou par</param>
    /// <param name="char_min">menor caracter que pode ser utilizado(33)</param>
    /// <param name="char_max">maior caracter que pode ser utilizado(126)</param>
    /// <returns></returns>
    private string EncriptyASCII(string text, bool use_even) 
    {
      int char_min = 0;
      int char_max = Chars.Length - 1;

      string VCrip = "";
      for (int i = 0; i < text.Length; i++)
      {
        int vc;//Valor ASCII
        char c;//Caracter ASCII

        vc = getIdxChar(text[i]);

        #region Verifica a distancia percorrida do caracter
        int posk =(i % Key.Length);
        int iKey = 0;
        if (posk < (Key.Length - 1))
        {
          string nx = Key[posk].ToString() + Key[posk + 1].ToString();
          iKey = Cnv.ToInt(nx);
        }
        else
        { iKey = Cnv.ToInt(Key[posk].ToString()); }
        #endregion

        #region Soma ou subtrai quando está criptografando ou descriptografando
        if ((i % 2) == Convert.ToInt16(use_even))
        { vc += iKey; }
        else
        { vc -= iKey; }
        #endregion

        #region Verifica se não estrapolou o limite do array
        int Dif = Chars.Length;
        while (vc < char_min || vc > char_max)
        {
          if (vc < char_min)
          { vc += Dif; }
          else if (vc > char_max)
          { vc -= Dif; }
        }
        #endregion

        c = Chars[vc];
        VCrip += c;
      }
      return VCrip;
    }
    #endregion

    #region public string Encrypt(string Text)
    /// <summary>
    /// Criptografa valor passado.
    /// </summary>
    /// <param name="Value">Valor sem criptografia.</param>
    /// <returns>Retorna o valor criptografado </returns>
    public string Encrypt(string Text)
    {
      return EncriptyASCII(Text, false);
    }
    #endregion

    #region public string Descrypt(string Value)
    /// <summary>
    /// Descriptografa valor passado.
    /// </summary>
    /// <param name="Value">Valor com criptografia</param>
    /// <returns>Retorna o valor descriptografado</returns>
    public string Descrypt(string Text)
    {
      return EncriptyASCII(Text, true);
    }
    #endregion

    #region public string getCodeFromText(string Text)
    public static string getCodeFromText(int StatWith,string Text)
    {
      long Total = StatWith;
      for (int I = 0; I < Text.Length; I++)
      { Total += ((int)Text[I]); }
      return Total.ToString();
    }
    #endregion
    #endregion

    #region public string GetSHA1(string Text)
    public static string GetSHA1(string Text)
    {
      try
      {
        byte[] SHA1HashValue = new SHA1Managed().ComputeHash(new UnicodeEncoding().GetBytes(Text));
        StringBuilder Retorno = new StringBuilder();

        foreach (byte b in SHA1HashValue)
        { Retorno.Append(b.ToString()); }
        return Retorno.ToString();
      }
      catch(Exception ex) { throw new Exception("Erro ao criptografar em SHA1", ex); }
    }
    #endregion

    #region public string GetMD5(string input)
    public static string GetMD5(string input)
    {
      System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create();
      byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
      byte[] hash = md5.ComputeHash(inputBytes);
      System.Text.StringBuilder sb = new System.Text.StringBuilder();
      for (int i = 0; i < hash.Length; i++)
      { sb.Append(hash[i].ToString("X2")); }
      return sb.ToString();
    }
        #endregion


        public String encripty(String s)
        {
            char[] c_source = s.ToCharArray();
            char[] c_destination = new char[c_source.Length];
            int add = 0;
            char c = '\0';
            for (int i = 0; i < c_source.Length; i++)
            {
                add = getValueKeyPosition(i);
                c = getCharMoveMap(add, c_source[i]);
                c_destination[i] = c;
            }
            return new String(c_destination);
        }

        public String descrypt(String s)
        {
            char[] c_source = s.ToCharArray();
            char[] c_destination = new char[c_source.Length];
            int add = 0;
            char c = '\0';
            for (int i = 0; i < c_source.Length; i++)
            {
                add = -getValueKeyPosition(i);
                c = getCharMoveMap(add, c_source[i]);
                c_destination[i] = c;
            }
            return new String(c_destination);
        }
    }
    */

    public class Encryption
    {
        private byte[] Key;
        private char[] CharacterMap;

        public Encryption(byte[] key)
        {
            //this.CharacterMap = " !\"#$%&'()*+,-./0123456789:;<=>?@ABCDEFGHIJKLMNOPQRSTUVWXYZ[\\]^_`abcdefghijklmnopqrstuvwxyz{|}~¡¢£¤¥¦§¨©ª«¬­®¯°±²³´µ¶·¸¹º»¼½¾¿ÀÁÂÃÄÅÆÇÈÉÊËÌÍÎÏÐÑÒÓÔÕÖ×ØÙÚÛÜÝÞßàáâãäåæçèéêëìíîïðñòóôõö÷øùúûüý".toCharArray();
            string numeros = "0123456789";
            string letras = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            string caracteres_extendidos = "ÀÁÂÃÄÅÇÈÉÊËÌÍÎÏÑÒÓÔÕÖÙÚÛÜÝàáâãäåçèéêëìíîïñòóôõöùúûüý";
            string digitos = " _()/|,;'";
            //string excluidos = "!\"#$%&*+-.:<=>?@[\\]^`{}~¡¢£¤¥¦§¨©ª«¬­®¯°±²³´µ¶·¸¹º»¼½¾¿Æ×ØÞßæ÷øÐð";
            string characterMap = (numeros + letras + caracteres_extendidos + digitos);

            Initialize(Key, characterMap);
        }

        public Encryption(byte[] key, String characterMap)
        {
            Initialize(key, characterMap);
        }

        public Encryption(string key, String characterMap)
        {
            Initialize(Encoding.ASCII.GetBytes(key), characterMap);
        }

        private void Initialize(byte[] key, String characterMap)
        {
            this.CharacterMap = characterMap.ToCharArray();
            this.Key = key;
        }

        public String getAllMap()
        {
            return " !\"#$%&'()*+,-./0123456789:;<=>?@ABCDEFGHIJKLMNOPQRSTUVWXYZ[\\]^_`abcdefghijklmnopqrstuvwxyz{|}~¡¢£¤¥¦§¨©ª«¬­®¯°±²³´µ¶·¸¹º»¼½¾¿ÀÁÂÃÄÅÆÇÈÉÊËÌÍÎÏÐÑÒÓÔÕÖ×ØÙÚÛÜÝÞßàáâãäåæçèéêëìíîïðñòóôõö÷øùúûüý";
        }

        public String encripty(String s)
        {
            char[] c_source = s.ToCharArray();
            char[] c_destination = new char[c_source.Length];
            int add = 0;
            char c = '\0';
            for (int i = 0; i < c_source.Length; i++)
            {
                add = getValueKeyPosition(i);
                c = getCharMoveMap(add, c_source[i]);
                c_destination[i] = c;
            }
            return new String(c_destination);
        }

        public String descrypt(String s)
        {
            char[] c_source = s.ToCharArray();
            char[] c_destination = new char[c_source.Length];
            int add = 0;
            char c = '\0';
            for (int i = 0; i < c_source.Length; i++)
            {
                add = -getValueKeyPosition(i);
                c = getCharMoveMap(add, c_source[i]);
                c_destination[i] = c;
            }
            return new String(c_destination);
        }

        private int getValueKeyPosition(int i_text_position)
        {
            int div = i_text_position / this.Key.Length;
            int pos = i_text_position - (this.Key.Length * div);
            return this.Key[pos];
        }

        private char getCharMoveMap(int add, char c)
        {
            int i_current_position = 0;
            for (int i = 0; i < this.CharacterMap.Length; i++)
            {
                if (this.CharacterMap[i] == c)
                {
                    i_current_position = i;
                    break;
                }
            }

            i_current_position += add;

            while (i_current_position >= this.CharacterMap.Length)
            {
                i_current_position -= this.CharacterMap.Length;
            }

            while (i_current_position < 0)
            {
                i_current_position += this.CharacterMap.Length;
            }

            return this.CharacterMap[i_current_position];
        }

        public static byte[] getNewKey()
        {
            return Guid.NewGuid().ToByteArray();
        }

        public static string getSHA1Bytes(string Text)
        {
            try
            {
                byte[] SHA1HashValue = new SHA1Managed().ComputeHash(new UnicodeEncoding().GetBytes(Text));
                StringBuilder Retorno = new StringBuilder();

                foreach (byte b in SHA1HashValue)
                { Retorno.Append(b.ToString()); }
                return Retorno.ToString();
            }
            catch (Exception ex) { throw new Exception("Erro ao criptografar em SHA1", ex); }
        }

        public static string getSHA1Hash(string input)
        {
            using (SHA1Managed sha1 = new SHA1Managed())
            {
                var hash = sha1.ComputeHash(Encoding.UTF8.GetBytes(input));
                var sb = new StringBuilder(hash.Length * 2);

                foreach (byte b in hash)
                {
                    // can be "x2" if you want lowercase
                    sb.Append(b.ToString("x2"));
                }

                return sb.ToString();
            }
        }

        public static string getMD5Hash(string input)
        {
            System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
            byte[] hash = md5.ComputeHash(inputBytes);
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            { sb.Append(hash[i].ToString("x2")); }
            return sb.ToString();
        }
    }
}
