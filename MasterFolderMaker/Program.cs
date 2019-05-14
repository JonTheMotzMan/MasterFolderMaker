using System;
using System.IO;
using System.Diagnostics;

namespace MasterFolderMaker
{
    class Program
    {
        static void Main(string[] args)
        {

            //Asks for the part's job number that'll be the new folder's name.
            Console.WriteLine("Please enter the new folder's job number.");
            string jobNumber = Console.ReadLine();

            //Creates the string directory path for the new folder.
            string directoryPath = "Z:\\Shared\\Part folders\\" + jobNumber;

            //Writes the directory path for the new job folder to verify it works as intended.
            Console.WriteLine(directoryPath);

            if (!Directory.Exists(directoryPath)){

                //Creates the new paths for the subfolders in the main section of the job folder.
                string jobFolderArchive = directoryPath + "\\Archive";
                string jobFolderCerts = directoryPath + "\\Certs";
                string jobFolderDeviations = directoryPath + "\\Deviations";
                string jobFolderHistory = directoryPath + "\\In-Process History";
                string jobFolderShipments = directoryPath + "\\Past Shipments";
                string jobFolderPrint = directoryPath + "\\Print";
                string jobFolderQuality = directoryPath + "\\Quality Docs";
                string jobFolderQuotes = directoryPath + "\\Quotes";
                string jobFolderRejects = directoryPath + "\\Rejects";

                //Creates the dash number folders for Certs, In-Process History, and Past Shipments.
                string certsFolder01 = jobFolderCerts + "\\-01";
                string certsFolder02 = jobFolderCerts + "\\-02";
                string certsFolder03 = jobFolderCerts + "\\-03";
                string certsFolder04 = jobFolderCerts + "\\-04";
                string certsFolder05 = jobFolderCerts + "\\-05";
                string certsFolder06 = jobFolderCerts + "\\-06";
                string certsFolder07 = jobFolderCerts + "\\-07";
                string certsFolder08 = jobFolderCerts + "\\-08";
                string certsFolder09 = jobFolderCerts + "\\-09";

                string historyFolder01 = jobFolderHistory + "\\-01";
                string historyFolder02 = jobFolderHistory + "\\-02";
                string historyFolder03 = jobFolderHistory + "\\-03";
                string historyFolder04 = jobFolderHistory + "\\-04";
                string historyFolder05 = jobFolderHistory + "\\-05";
                string historyFolder06 = jobFolderHistory + "\\-06";
                string historyFolder07 = jobFolderHistory + "\\-07";
                string historyFolder08 = jobFolderHistory + "\\-08";
                string historyFolder09 = jobFolderHistory + "\\-09";

                string shipmentsFolder01 = jobFolderShipments + "\\-01";
                string shipmentsFolder02 = jobFolderShipments + "\\-02";
                string shipmentsFolder03 = jobFolderShipments + "\\-03";
                string shipmentsFolder04 = jobFolderShipments + "\\-04";
                string shipmentsFolder05 = jobFolderShipments + "\\-05";
                string shipmentsFolder06 = jobFolderShipments + "\\-06";
                string shipmentsFolder07 = jobFolderShipments + "\\-07";
                string shipmentsFolder08 = jobFolderShipments + "\\-08";
                string shipmentsFolder09 = jobFolderShipments + "\\-09";

                //Creates the obsolete folders for the neccasary folders, Print and Quality Docs.

                string printObsolete = jobFolderPrint + "\\Obsolete";

                string qualityObsolete = jobFolderQuality + "\\Obsolete";

                try
                {
                    //Creates the folder in the specified directory

                    Directory.CreateDirectory(directoryPath);

                    //Creates the main level subfolders in the new directory folder.

                    Directory.CreateDirectory(jobFolderArchive);
                    Directory.CreateDirectory(jobFolderCerts);
                    Directory.CreateDirectory(jobFolderDeviations);
                    Directory.CreateDirectory(jobFolderHistory);
                    Directory.CreateDirectory(jobFolderPrint);
                    Directory.CreateDirectory(jobFolderQuality);
                    Directory.CreateDirectory(jobFolderQuotes);
                    Directory.CreateDirectory(jobFolderRejects);
                    Directory.CreateDirectory(jobFolderShipments);

                    //Populates the subfolders of the main directory to the dash numbers.

                    Directory.CreateDirectory(certsFolder01);
                    Directory.CreateDirectory(certsFolder02);
                    Directory.CreateDirectory(certsFolder03);
                    Directory.CreateDirectory(certsFolder04);
                    Directory.CreateDirectory(certsFolder05);
                    Directory.CreateDirectory(certsFolder06);
                    Directory.CreateDirectory(certsFolder07);
                    Directory.CreateDirectory(certsFolder08);
                    Directory.CreateDirectory(certsFolder09);

                    Directory.CreateDirectory(historyFolder01);
                    Directory.CreateDirectory(historyFolder02);
                    Directory.CreateDirectory(historyFolder03);
                    Directory.CreateDirectory(historyFolder04);
                    Directory.CreateDirectory(historyFolder05);
                    Directory.CreateDirectory(historyFolder06);
                    Directory.CreateDirectory(historyFolder07);
                    Directory.CreateDirectory(historyFolder08);
                    Directory.CreateDirectory(historyFolder09);

                    Directory.CreateDirectory(shipmentsFolder01);
                    Directory.CreateDirectory(shipmentsFolder02);
                    Directory.CreateDirectory(shipmentsFolder03);
                    Directory.CreateDirectory(shipmentsFolder04);
                    Directory.CreateDirectory(shipmentsFolder05);
                    Directory.CreateDirectory(shipmentsFolder06);
                    Directory.CreateDirectory(shipmentsFolder07);
                    Directory.CreateDirectory(shipmentsFolder08);
                    Directory.CreateDirectory(shipmentsFolder09);

                    //Creates the obsolete folders to match the template.

                    Directory.CreateDirectory(printObsolete);
                    Directory.CreateDirectory(qualityObsolete);


                    // Begins InspectionXpert to begin populating the new job folder.
                    Process p1 = Process.Start("InspectionXpert OnDemand 2.0 x64.appref-ms");

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                finally
                {
                    Console.WriteLine("---- END IF ERROR HANDLING EXAMPLE");
                }
            }

            else
            {
                Console.WriteLine("This part folder already exists.");
            }
        }
    }
}
