using System;
using System.Diagnostics;
using System.IO;
using System.Net;

namespace Console5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pathInput = @"input.txt";
            string pathOutput = @"output.txt";
            int timeout = 20000; // 20 сек.
            string method = "HEAD";
            bool openInBrowser = true;
            //if (!File.Exists(pathInput))
            //{
            //    return;
            //}
            using (StreamReader sr = File.OpenText(pathInput))
            {
                using (StreamWriter sw = File.CreateText(pathOutput))
                {
                    string urlString = null;
                    while ((urlString = sr.ReadLine()) != null)
                    {
                        UriBuilder builder = new UriBuilder(urlString);
                        Uri uri = builder.Uri;
                        HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri);
                        request.Timeout = timeout;
                        request.Method = method;
                        // игнорировать проблемы с сертификатами
                        ServicePointManager.ServerCertificateValidationCallback = new System.Net.Security.RemoteCertificateValidationCallback(AcceptAllCertifications);

                        try
                        {
                            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                            {
                                if (response.StatusCode == HttpStatusCode.OK)
                                {
                                    sw.WriteLine(urlString);
                                    if (openInBrowser)
                                    {
                                        openInBrowser = false;
                                        Process p = new Process();
                                        p.StartInfo.UseShellExecute = true;
                                        p.StartInfo.FileName = uri.ToString();
                                        p.Start();
                                    }
                                }

                                response.Close();
                            }

                        }
                        /*
                        catch (WebException we)
                        {
                            //we.Status == WebExceptionStatus.ProtocolError
                            //we.Status == WebExceptionStatus.Timeout
                        }
                        */
                        catch (Exception )
                        { }
                    }
                }
            }
        }

        static bool AcceptAllCertifications(object sender, System.Security.Cryptography.X509Certificates.X509Certificate certification, System.Security.Cryptography.X509Certificates.X509Chain chain, System.Net.Security.SslPolicyErrors sslPolicyErrors)
        {
            return true;
        }
        
    }
}
