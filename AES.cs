// See https://aka.ms/new-console-template for more information
// This project demonstrates how AES encryption is established within an application.
// The references used for this project are found here: https://learn.microsoft.com/en-us/dotnet/api/system.security.cryptography.aes?view=net-7.0
// For plaintext, we will be using the Cupcake Ipsum website generator here: https://cupcakeipsum.com/

using System;
using System.IO;
using System.Security.Cryptography;

namespace AES_Cupcake
{
    class AES_Cupcake
    {
        public static void Main()
        {
            string cupcakeOrigin = "Cake tiramisu sweet marshmallow tart lemon drops. Muffin icing tiramisu marshmallow wafer toffee jelly beans marshmallow shortbread. Jujubes cake fruitcake fruitcake chocolate cake. Cotton candy chupa chups jelly beans danish apple pie cake. Bonbon marzipan cake tart donut cheesecake lollipop. Tart chocolate bar gummi bears powder icing soufflé pudding. Macaroon cookie jujubes wafer fruitcake sugar plum.";

            using (Aes cupcakeAes = Aes.Create())
            {
                byte[] cupcakeEncrypted = EncryptStringToBytes_Aes(cupcakeOrigin, cupcakeAes.Key, cupcakeAes.IV);
                string cupcakeDecrypt = DecryptStringFromBytes_Aes(cupcakeEncrypted, cupcakeAes.Key, cupcakeAes.IV);

                // Display all encrypted and decrypted data.

                Console.WriteLine("Original Cupcake Data:  {0}", cupcakeOrigin);
                Console.WriteLine("Decrypted Cupcake Data:  {0}", cupcakeDecrypt);
            }
        }

      
      // Encrypt the plaintext from Cupcake Ipsum.

        static byte[] EncryptStringToBytes_Aes(string cupcakePlain, byte[] key, byte[] iV)
        {
            // AES argument check.

            if (cupcakePlain == null || cupcakePlain.Length <= 1)
                throw new ArgumentNullException("cupcakePlain");
            if (key == null || key.Length <= 1)
                throw new ArgumentNullException("key");
            if (iV == null || iV.Length <= 1)
                throw new ArgumentNullException("iV");

            byte[] cupcakeEncrypted;

            // Establish the AES Object.

            using (Aes cupcakeAlg = Aes.Create())
            {
                cupcakeAlg.Key = key;
                cupcakeAlg.IV = iV;

                ICryptoTransform cupcakeEncryptor = cupcakeAlg.CreateEncryptor(cupcakeAlg.Key, cupcakeAlg.IV);

                using (MemoryStream cupcakeEncrypt = new MemoryStream())
                {
                    using (CryptoStream jellyEncrypt = new CryptoStream(cupcakeEncrypt, cupcakeEncryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter lemonEncrypt = new StreamWriter(jellyEncrypt))
                        {
                            
                            lemonEncrypt.Write(cupcakePlain);
                        }

                        cupcakeEncrypted = cupcakeEncrypt.ToArray();

                    }
                }
                return cupcakeEncrypted;
            }
        }


        // Decrypt the plaintext from Cupcake Ipsum.

        private static string DecryptStringFromBytes_Aes(byte[] cupcakeCipher, byte[] key, byte[] iV)
        {
            

            if (cupcakeCipher == null || cupcakeCipher.Length <= 1)
                throw new ArgumentNullException("cupcakeCipher");
            if (key == null || key.Length <= 1)
                throw new ArgumentNullException("key");
            if (iV == null || iV.Length <= 1)
                throw new ArgumentNullException("iV");

            string cupcakeText = null;

            using (Aes cupcakeAlg = Aes.Create())
            {
                cupcakeAlg.Key = key;
                cupcakeAlg.IV = iV;

                ICryptoTransform cupcakeDecryptor = cupcakeAlg.CreateDecryptor(cupcakeAlg.Key, cupcakeAlg.IV);

                using (MemoryStream cupcakeDecrypt = new MemoryStream(cupcakeCipher))
                {
                    using (CryptoStream jellyDecrypt = new CryptoStream(cupcakeDecrypt, cupcakeDecryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader lemonDecrypt = new StreamReader(jellyDecrypt))
                        {

                            cupcakeText = lemonDecrypt.ReadToEnd();
                        }
                    }
                }
            }
            return cupcakeText;
        }
    }
}

