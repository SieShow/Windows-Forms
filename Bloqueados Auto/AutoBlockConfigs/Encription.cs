﻿using System.IO;

namespace AutoCRM
{
    public static class Encription
    {
        private static string[] Line = new string[191]; // vetor contendo todas as linhas da Key
        /// <summary>
        /// Lê o arquivo container de chaves e Encripta cada linha neste arquivo
        /// </summary>
        /// <param name="msg">Menssagem/Linha</param>
        /// <returns></returns>
        public static string Encryption(string msg) // Encriptação "DEMOREI PRA CARAI"
        {
            LerChave();
            string Enc = " ";
            int i = 0, x = 0, y = 0;
            string character, msgENC = "";

            while (x != msg.Length)
            { // enquanto não pegar todos os caracteres da mensagem

                Enc = msg.Substring(y, 1); // variável Enc recebera o 1 caracter da mensagem
                y++;
                i = 0;
                do
                {
                    character = Line[i].Substring(0, 4); // no arquivo Key, character recebe o primeiro valor unicode para comparar ao caracter da mensagem
                    int code = int.Parse(character, System.Globalization.NumberStyles.HexNumber); // converte o valor unicode para Hex
                    character = char.ConvertFromUtf32(code); // converte o valor hex para UTF-32 e character recebe esse valor

                    if (Enc == character) // 
                    {
                        msgENC += Line[i].Substring(5, Line[i].Length - 5);
                    }
                    i++;

                } while (Enc != character);

                x++;
            }
            return msgENC;
        }
        /// <summary>
        /// Método interno da classe. Le o Arquivo com todos as teclas UNICODE e sua respectiva cadeia de caracteres correspondentes
        /// </summary>
        private static void LerChave()
        {
            StreamReader File = new StreamReader("KeyFileCodes");

            for (int i = 0; i < 191; i++)
            {
                Line[i] = File.ReadLine();
            }
            File.Close();
        }
        /// <summary>
        /// Decripta a linha salva no arquivo, no qual está encriptografada com a sequencia usada por essa classe
        /// </summary>
        /// <param name="line">Menssagem/Linha</param>
        /// <returns></returns>
        public static string Decription(string line)
        {
            LerChave();
            int test = 5;
            string Converted = "", resp = "";
            while (line != "")
            {
                int i = 0;

                string get = line.Substring(0, test);

                while (get != Line[i].Substring(5, get.Length))
                {
                    i++;
                }
                if (get == Line[i].Substring(5, get.Length))
                {
                    Converted = Line[i].Substring(0, 4);
                    int code = int.Parse(Converted, System.Globalization.NumberStyles.HexNumber);
                    Converted = char.ConvertFromUtf32(code);
                    resp += Converted;

                    string size = Line[i].Substring(5, Line[i].Length - 5);
                    line = line.Substring(size.Length, line.Length - size.Length);

                }
            }
            return resp;
        }
    }
}
