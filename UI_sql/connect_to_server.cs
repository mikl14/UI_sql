using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;
using System.IO;

namespace UI_sql
{
    public class connect_to_server
    {
        // Устанавливаем IP-адрес и порт сервера
       
        string fileName;

        public void Connect_and_Request_to_server(string request)
        {

            IPAddress ipAddress = IPAddress.Parse("62.140.233.174");
            int port = 41233;

            // Создаем TCP клиента
            TcpClient client = new TcpClient();

            // Подключаемся к серверу
            client.Connect(ipAddress, port);
            Console.WriteLine("Подключение к серверу установлено.");

            // Получаем поток для чтения и записи данных
            NetworkStream stream = client.GetStream();

           // string request = "SELECT * FROM kirov LIMIT 1";
            byte[] request_data = Encoding.UTF8.GetBytes(request);
            stream.Write(request_data, 0, request_data.Length);
            // Отправляем запрос серверу на передачу файла

            // Читаем данные от клиента (имя файла и его размер)
            byte[] fileNameData = new byte[256];
            int fileNameBytes = stream.Read(fileNameData, 0, fileNameData.Length);
            fileName = Encoding.UTF8.GetString(fileNameData, 0, fileNameBytes);

            byte[] fileSizeData = new byte[4];
            int fileSizeBytes = stream.Read(fileSizeData, 0, fileSizeData.Length);
            int fileSize = BitConverter.ToInt32(fileSizeData, 0);

            Console.WriteLine("Получен запрос от клиента на передачу файла: " + fileName);

            // Создаем буфер для чтения данных файла
            byte[] buffer = new byte[1024];
            int bytesRead;
            int totalBytesRead = 0;

            // Создаем файл на сервере для записи данных
            FileStream fileStream = File.Create(fileName);

            // Читаем данные файла от клиента и записываем их в файл на сервере
            while ((bytesRead = stream.Read(buffer, 0, buffer.Length)) > 0)
            {
                fileStream.Write(buffer, 0, bytesRead);
                totalBytesRead += bytesRead;

                // Проверяем, достигнут ли размер файла
                if (totalBytesRead >= fileSize)
                {
                    break;
                }
            }

            Console.WriteLine("Файл " + fileName + " успешно принят от клиента.");
            fileStream.Close();
            // Закрываем подключение
            stream.Close();
            client.Close();
            Console.WriteLine("Подключение закрыто.");
        }



        public string get_filename()
        {
            return fileName;
        }
    }

}
