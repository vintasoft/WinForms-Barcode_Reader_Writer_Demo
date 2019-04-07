using System;
using System.IO;
using System.Xml.Serialization;
using Vintasoft.Barcode;
using Vintasoft.Barcode.SymbologySubsets;

namespace BarcodeReaderConsoleDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                if (args.Length < 1)
                {
                    Console.WriteLine("Usage: BarcodeReaderConsoleDemo imageFilename [BarcodeType1] [BarcodeType2] ...");
                    Console.WriteLine("Usage: BarcodeReaderConsoleDemo imageFilename ReaderSettings.xml");
                    return;
                }

                // register custom encodings for QR and HanXin Code barcodes 
                // (System.Text.Encoding.CodePages package)
                System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);

                // image with barcode
                string filename = args[0];

                try
                {
                    // create barcode reader
                    using (BarcodeReader reader = new BarcodeReader())
                    {
                        if (args.Length == 2 && File.Exists(args[1]))
                        {
                            // deserialize the barcode reader settings from file
                            XmlSerializer serializer = new XmlSerializer(typeof(ReaderSettings));
                            using (FileStream stream = new FileStream(args[1], FileMode.Open, FileAccess.Read))
                                reader.Settings = (ReaderSettings)serializer.Deserialize(stream);
                        }
                        else
                        {
                            // set default reader settings
                            reader.Settings.AutomaticRecognition = true;
                            reader.Settings.ScanDirection = ScanDirection.Horizontal | ScanDirection.Vertical;

                            // set scan barcode types
                            reader.Settings.ScanBarcodeTypes = BarcodeType.None;
                            if (args.Length == 1)
                            {
                                SetAllBarcodeTypes(reader.Settings);
                            }
                            else
                            {
                                for (int i = 1; i < args.Length; i++)
                                    AddBarcodeType(reader.Settings, args[i]);
                            }
                        }

                        // read barcodes
                        Console.Write("Recognition...");
                        IBarcodeInfo[] infos = reader.ReadBarcodes(filename);
                        Console.WriteLine(string.Format("{0} ms.", reader.RecognizeTime.TotalMilliseconds));
                        Console.WriteLine();

                        // display recognition results
                        PrintResults(infos);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(string.Format("Error: {0}", ex.Message));
                }
            }
            finally
            {
                Console.WriteLine("Press any key...");
                Console.ReadKey();
            }
        }

        /// <summary>
        /// Prints barcode recognition results.
        /// </summary>
        /// <param name="infos">The barcode recognition results.</param>
        private static void PrintResults(IBarcodeInfo[] infos)
        {
            if (infos.Length == 0)
            {
                Console.WriteLine("No barcodes found.");
            }
            else
            {
                Console.WriteLine(string.Format("{0} barcodes found:", infos.Length));
                Console.WriteLine();
                for (int i = 0; i < infos.Length; i++)
                {
                    IBarcodeInfo info = infos[i];
                    Console.WriteLine(string.Format("[{0}:{1}]", i, info.BarcodeType));
                    Console.WriteLine(string.Format("Value:      {0}", info.Value));
                    Console.WriteLine(string.Format("Confidence: {0}%", Math.Round(info.Confidence)));
                    Console.WriteLine(string.Format("Threshold:  {0}", info.Threshold));
                    Console.WriteLine(string.Format("Region:     {0}", info.Region));
                    Console.WriteLine();
                }
            }
        }

        /// <summary>
        /// Add specified barcode type to reader settings.
        /// </summary>
        /// <param name="settings">The reader settings.</param>
        /// <param name="name">Barcode type to add.</param>
        private static void AddBarcodeType(ReaderSettings settings, string name)
        {
            switch (name)
            {
                case "AustralianPost":
                    settings.ScanBarcodeTypes |= BarcodeType.AustralianPost;
                    break;
                case "Aztec":
                    settings.ScanBarcodeTypes |= BarcodeType.Aztec;
                    break;
                case "Codabar":
                    settings.ScanBarcodeTypes |= BarcodeType.Codabar;
                    break;
                case "Code11":
                    settings.ScanBarcodeTypes |= BarcodeType.Code11;
                    break;
                case "Code128":
                    settings.ScanBarcodeTypes |= BarcodeType.Code128;
                    break;
                case "Code16K":
                    settings.ScanBarcodeTypes |= BarcodeType.Code16K;
                    break;
                case "Code39":
                    settings.ScanBarcodeTypes |= BarcodeType.Code39;
                    break;
                case "Code93":
                    settings.ScanBarcodeTypes |= BarcodeType.Code93;
                    break;
                case "DataMatrix":
                    settings.ScanBarcodeTypes |= BarcodeType.DataMatrix;
                    break;
                case "DutchKIX":
                    settings.ScanBarcodeTypes |= BarcodeType.DutchKIX;
                    break;
                case "EAN13":
                    settings.ScanBarcodeTypes |= BarcodeType.EAN13;
                    break;
                case "EAN13Plus2":
                    settings.ScanBarcodeTypes |= BarcodeType.EAN13Plus2;
                    break;
                case "EAN13Plus5":
                    settings.ScanBarcodeTypes |= BarcodeType.EAN13Plus5;
                    break;
                case "EAN8":
                    settings.ScanBarcodeTypes |= BarcodeType.EAN8;
                    break;
                case "EAN8Plus2":
                    settings.ScanBarcodeTypes |= BarcodeType.EAN8Plus2;
                    break;
                case "EAN8Plus5":
                    settings.ScanBarcodeTypes |= BarcodeType.EAN8Plus5;
                    break;
                case "HanXinCode":
                    settings.ScanBarcodeTypes |= BarcodeType.HanXinCode;
                    break;
                case "IATA2of5":
                    settings.ScanBarcodeTypes |= BarcodeType.IATA2of5;
                    break;
                case "IntelligentMail":
                    settings.ScanBarcodeTypes |= BarcodeType.IntelligentMail;
                    break;
                case "Interleaved2of5":
                    settings.ScanBarcodeTypes |= BarcodeType.Interleaved2of5;
                    break;
                case "Mailmark4StateC":
                    settings.ScanBarcodeTypes |= BarcodeType.Mailmark4StateC;
                    break;
                case "Mailmark4StateL":
                    settings.ScanBarcodeTypes |= BarcodeType.Mailmark4StateL;
                    break;
                case "Matrix2of5":
                    settings.ScanBarcodeTypes |= BarcodeType.Matrix2of5;
                    break;
                case "MaxiCode":
                    settings.ScanBarcodeTypes |= BarcodeType.MaxiCode;
                    break;
                case "MicroPDF417":
                    settings.ScanBarcodeTypes |= BarcodeType.MicroPDF417;
                    break;
                case "MicroQR":
                    settings.ScanBarcodeTypes |= BarcodeType.MicroQR;
                    break;
                case "MSI":
                    settings.ScanBarcodeTypes |= BarcodeType.MSI;
                    break;
                case "PDF417":
                    settings.ScanBarcodeTypes |= BarcodeType.PDF417;
                    break;
                case "PDF417Compact":
                    settings.ScanBarcodeTypes |= BarcodeType.PDF417Compact;
                    break;
                case "PatchCode":
                    settings.ScanBarcodeTypes |= BarcodeType.PatchCode;
                    break;
                case "Pharmacode":
                    settings.ScanBarcodeTypes |= BarcodeType.Pharmacode;
                    break;
                case "Planet":
                    settings.ScanBarcodeTypes |= BarcodeType.Planet;
                    break;
                case "Postnet":
                    settings.ScanBarcodeTypes |= BarcodeType.Postnet;
                    break;
                case "QR":
                    settings.ScanBarcodeTypes |= BarcodeType.QR;
                    break;
                case "RoyalMail":
                    settings.ScanBarcodeTypes |= BarcodeType.RoyalMail;
                    break;
                case "RSS14":
                    settings.ScanBarcodeTypes |= BarcodeType.RSS14;
                    break;
                case "RSS14Stacked":
                    settings.ScanBarcodeTypes |= BarcodeType.RSS14Stacked;
                    break;
                case "RSSExpanded":
                    settings.ScanBarcodeTypes |= BarcodeType.RSSExpanded;
                    break;
                case "RSSExpandedStacked":
                    settings.ScanBarcodeTypes |= BarcodeType.RSSExpandedStacked;
                    break;
                case "RSSLimited":
                    settings.ScanBarcodeTypes |= BarcodeType.RSSLimited;
                    break;
                case "Standard2of5":
                    settings.ScanBarcodeTypes |= BarcodeType.Standard2of5;
                    break;
                case "Telepen":
                    settings.ScanBarcodeTypes |= BarcodeType.Telepen;
                    break;
                case "UPCA":
                    settings.ScanBarcodeTypes |= BarcodeType.UPCA;
                    break;
                case "UPCAPlus2":
                    settings.ScanBarcodeTypes |= BarcodeType.UPCAPlus2;
                    break;
                case "UPCAPlus5":
                    settings.ScanBarcodeTypes |= BarcodeType.UPCAPlus5;
                    break;
                case "UPCE":
                    settings.ScanBarcodeTypes |= BarcodeType.UPCE;
                    break;
                case "UPCEPlus2":
                    settings.ScanBarcodeTypes |= BarcodeType.UPCEPlus2;
                    break;
                case "UPCEPlus5":
                    settings.ScanBarcodeTypes |= BarcodeType.UPCEPlus5;
                    break;
                case "AAMVA":
                    settings.ScanBarcodeSubsets.Add(BarcodeSymbologySubsets.AAMVA);
                    break;
                case "Code32":
                    settings.ScanBarcodeSubsets.Add(BarcodeSymbologySubsets.Code32);
                    break;
                case "Code39Extended":
                    settings.ScanBarcodeSubsets.Add(BarcodeSymbologySubsets.Code39Extended);
                    break;
                case "DeutschePostIdentcode":
                    settings.ScanBarcodeSubsets.Add(BarcodeSymbologySubsets.DeutschePostIdentcode);
                    break;
                case "DeutschePostLeitcode":
                    settings.ScanBarcodeSubsets.Add(BarcodeSymbologySubsets.DeutschePostLeitcode);
                    break;
                case "DhlAwb":
                    settings.ScanBarcodeSubsets.Add(BarcodeSymbologySubsets.DhlAwb);
                    break;
                case "EANVelocity":
                    settings.ScanBarcodeSubsets.Add(BarcodeSymbologySubsets.EANVelocity);
                    break;
                case "FedExGround96":
                    settings.ScanBarcodeSubsets.Add(BarcodeSymbologySubsets.FedExGround96);
                    break;
                case "GS1Aztec":
                    settings.ScanBarcodeSubsets.Add(BarcodeSymbologySubsets.GS1Aztec);
                    break;
                case "GS1DataBar":
                    settings.ScanBarcodeSubsets.Add(BarcodeSymbologySubsets.GS1DataBar);
                    break;
                case "GS1DataBarExpanded":
                    settings.ScanBarcodeSubsets.Add(BarcodeSymbologySubsets.GS1DataBarExpanded);
                    break;
                case "GS1DataBarExpandedStacked":
                    settings.ScanBarcodeSubsets.Add(BarcodeSymbologySubsets.GS1DataBarExpandedStacked);
                    break;
                case "GS1DataBarLimited":
                    settings.ScanBarcodeSubsets.Add(BarcodeSymbologySubsets.GS1DataBarLimited);
                    break;
                case "GS1DataBarStacked":
                    settings.ScanBarcodeSubsets.Add(BarcodeSymbologySubsets.GS1DataBarStacked);
                    break;
                case "GS1DataMatrix":
                    settings.ScanBarcodeSubsets.Add(BarcodeSymbologySubsets.GS1DataMatrix);
                    break;
                case "GS1QR":
                    settings.ScanBarcodeSubsets.Add(BarcodeSymbologySubsets.GS1QR);
                    break;
                case "GS1_128":
                    settings.ScanBarcodeSubsets.Add(BarcodeSymbologySubsets.GS1_128);
                    break;
                case "Interleaved2of5ChecksumISO16390":
                    settings.ScanBarcodeSubsets.Add(BarcodeSymbologySubsets.Interleaved2of5ChecksumISO16390);
                    break;
                case "Interleaved2of5ChecksumMod10C":
                    settings.ScanBarcodeSubsets.Add(BarcodeSymbologySubsets.Interleaved2of5ChecksumMod10C);
                    break;
                case "ISBN":
                    settings.ScanBarcodeSubsets.Add(BarcodeSymbologySubsets.ISBN);
                    break;
                case "ISBNPlus2":
                    settings.ScanBarcodeSubsets.Add(BarcodeSymbologySubsets.ISBNPlus2);
                    break;
                case "ISBNPlus5":
                    settings.ScanBarcodeSubsets.Add(BarcodeSymbologySubsets.ISBNPlus5);
                    break;
                case "ISMN":
                    settings.ScanBarcodeSubsets.Add(BarcodeSymbologySubsets.ISMN);
                    break;
                case "ISMNPlus2":
                    settings.ScanBarcodeSubsets.Add(BarcodeSymbologySubsets.ISMNPlus2);
                    break;
                case "ISMNPlus5":
                    settings.ScanBarcodeSubsets.Add(BarcodeSymbologySubsets.ISMNPlus5);
                    break;
                case "ISSN":
                    settings.ScanBarcodeSubsets.Add(BarcodeSymbologySubsets.ISSN);
                    break;
                case "ISSNPlus2":
                    settings.ScanBarcodeSubsets.Add(BarcodeSymbologySubsets.ISSNPlus2);
                    break;
                case "ISSNPlus5":
                    settings.ScanBarcodeSubsets.Add(BarcodeSymbologySubsets.ISSNPlus5);
                    break;
                case "ITF14":
                    settings.ScanBarcodeSubsets.Add(BarcodeSymbologySubsets.ITF14);
                    break;
                case "JAN13":
                    settings.ScanBarcodeSubsets.Add(BarcodeSymbologySubsets.JAN13);
                    break;
                case "JAN13Plus2":
                    settings.ScanBarcodeSubsets.Add(BarcodeSymbologySubsets.JAN13Plus2);
                    break;
                case "JAN13Plus5":
                    settings.ScanBarcodeSubsets.Add(BarcodeSymbologySubsets.JAN13Plus5);
                    break;
                case "JAN8":
                    settings.ScanBarcodeSubsets.Add(BarcodeSymbologySubsets.JAN8);
                    break;
                case "JAN8Plus2":
                    settings.ScanBarcodeSubsets.Add(BarcodeSymbologySubsets.JAN8Plus2);
                    break;
                case "JAN8Plus5":
                    settings.ScanBarcodeSubsets.Add(BarcodeSymbologySubsets.JAN8Plus5);
                    break;
                case "MailmarkCmdmType29":
                    settings.ScanBarcodeSubsets.Add(BarcodeSymbologySubsets.MailmarkCmdmType29);
                    break;
                case "MailmarkCmdmType7":
                    settings.ScanBarcodeSubsets.Add(BarcodeSymbologySubsets.MailmarkCmdmType7);
                    break;
                case "MailmarkCmdmType9":
                    settings.ScanBarcodeSubsets.Add(BarcodeSymbologySubsets.MailmarkCmdmType9);
                    break;
                case "NumlyNumber":
                    settings.ScanBarcodeSubsets.Add(BarcodeSymbologySubsets.NumlyNumber);
                    break;
                case "OPC":
                    settings.ScanBarcodeSubsets.Add(BarcodeSymbologySubsets.OPC);
                    break;
                case "PPN":
                    settings.ScanBarcodeSubsets.Add(BarcodeSymbologySubsets.PPN);
                    break;
                case "PZN":
                    settings.ScanBarcodeSubsets.Add(BarcodeSymbologySubsets.PZN);
                    break;
                case "SSCC18":
                    settings.ScanBarcodeSubsets.Add(BarcodeSymbologySubsets.SSCC18);
                    break;
                case "SwissPostParcel":
                    settings.ScanBarcodeSubsets.Add(BarcodeSymbologySubsets.SwissPostParcel);
                    break;
                case "VicsBol":
                    settings.ScanBarcodeSubsets.Add(BarcodeSymbologySubsets.VicsBol);
                    break;
                case "VicsScacPro":
                    settings.ScanBarcodeSubsets.Add(BarcodeSymbologySubsets.VicsScacPro);
                    break;
                case "VIN":
                    settings.ScanBarcodeSubsets.Add(BarcodeSymbologySubsets.VIN);
                    break;
                case "XFACompressedAztec":
                    settings.ScanBarcodeSubsets.Add(BarcodeSymbologySubsets.XFACompressedAztec);
                    break;
                case "XFACompressedDataMatrix":
                    settings.ScanBarcodeSubsets.Add(BarcodeSymbologySubsets.XFACompressedDataMatrix);
                    break;
                case "XFACompressedPDF417":
                    settings.ScanBarcodeSubsets.Add(BarcodeSymbologySubsets.XFACompressedPDF417);
                    break;
                case "XFACompressedQRCode":
                    settings.ScanBarcodeSubsets.Add(BarcodeSymbologySubsets.XFACompressedQRCode);
                    break;
                default:
                    throw new NotSupportedException(string.Format("Barcode type '{0}' is undefined.", name));
            }
        }

        /// <summary>
        /// Sets all supported barcode types and subsets to specified reader settings.
        /// </summary>
        /// <param name="settings">The reader settings.</param>
        private static void SetAllBarcodeTypes(ReaderSettings settings)
        {
            //settings.ScanBarcodeTypes |= BarcodeType.PatchCode; // not supported in demo version
            //settings.ScanBarcodeTypes |= BarcodeType.Pharmacode;

            settings.ScanBarcodeTypes |= BarcodeType.AustralianPost;
            settings.ScanBarcodeTypes |= BarcodeType.Aztec;
            settings.ScanBarcodeTypes |= BarcodeType.Codabar;
            settings.ScanBarcodeTypes |= BarcodeType.Code11;
            settings.ScanBarcodeTypes |= BarcodeType.Code128;
            settings.ScanBarcodeTypes |= BarcodeType.Code16K;
            settings.ScanBarcodeTypes |= BarcodeType.Code39;
            settings.ScanBarcodeTypes |= BarcodeType.Code93;
            settings.ScanBarcodeTypes |= BarcodeType.DataMatrix;
            settings.ScanBarcodeTypes |= BarcodeType.DutchKIX;
            settings.ScanBarcodeTypes |= BarcodeType.EAN13;
            settings.ScanBarcodeTypes |= BarcodeType.EAN13Plus2;
            settings.ScanBarcodeTypes |= BarcodeType.EAN13Plus5;
            settings.ScanBarcodeTypes |= BarcodeType.EAN8;
            settings.ScanBarcodeTypes |= BarcodeType.EAN8Plus2;
            settings.ScanBarcodeTypes |= BarcodeType.EAN8Plus5;
            settings.ScanBarcodeTypes |= BarcodeType.HanXinCode;
            settings.ScanBarcodeTypes |= BarcodeType.IATA2of5;
            settings.ScanBarcodeTypes |= BarcodeType.IntelligentMail;
            settings.ScanBarcodeTypes |= BarcodeType.Interleaved2of5;
            settings.ScanBarcodeTypes |= BarcodeType.Mailmark4StateC;
            settings.ScanBarcodeTypes |= BarcodeType.Mailmark4StateL;
            settings.ScanBarcodeTypes |= BarcodeType.Matrix2of5;
            settings.ScanBarcodeTypes |= BarcodeType.MaxiCode;
            settings.ScanBarcodeTypes |= BarcodeType.MicroPDF417;
            settings.ScanBarcodeTypes |= BarcodeType.MicroQR;
            settings.ScanBarcodeTypes |= BarcodeType.MSI;
            settings.ScanBarcodeTypes |= BarcodeType.PDF417;
            settings.ScanBarcodeTypes |= BarcodeType.PDF417Compact;
            settings.ScanBarcodeTypes |= BarcodeType.Planet;
            settings.ScanBarcodeTypes |= BarcodeType.Postnet;
            settings.ScanBarcodeTypes |= BarcodeType.QR;
            settings.ScanBarcodeTypes |= BarcodeType.RoyalMail;
            settings.ScanBarcodeTypes |= BarcodeType.RSS14;
            settings.ScanBarcodeTypes |= BarcodeType.RSS14Stacked;
            settings.ScanBarcodeTypes |= BarcodeType.RSSExpanded;
            settings.ScanBarcodeTypes |= BarcodeType.RSSExpandedStacked;
            settings.ScanBarcodeTypes |= BarcodeType.RSSLimited;
            settings.ScanBarcodeTypes |= BarcodeType.Standard2of5;
            settings.ScanBarcodeTypes |= BarcodeType.Telepen;
            settings.ScanBarcodeTypes |= BarcodeType.UPCA;
            settings.ScanBarcodeTypes |= BarcodeType.UPCAPlus2;
            settings.ScanBarcodeTypes |= BarcodeType.UPCAPlus5;
            settings.ScanBarcodeTypes |= BarcodeType.UPCE;
            settings.ScanBarcodeTypes |= BarcodeType.UPCEPlus2;
            settings.ScanBarcodeTypes |= BarcodeType.UPCEPlus5;
            settings.ScanBarcodeSubsets.Add(BarcodeSymbologySubsets.AAMVA);
            settings.ScanBarcodeSubsets.Add(BarcodeSymbologySubsets.Code32);
            settings.ScanBarcodeSubsets.Add(BarcodeSymbologySubsets.Code39Extended);
            settings.ScanBarcodeSubsets.Add(BarcodeSymbologySubsets.DeutschePostIdentcode);
            settings.ScanBarcodeSubsets.Add(BarcodeSymbologySubsets.DeutschePostLeitcode);
            settings.ScanBarcodeSubsets.Add(BarcodeSymbologySubsets.DhlAwb);
            settings.ScanBarcodeSubsets.Add(BarcodeSymbologySubsets.EANVelocity);
            settings.ScanBarcodeSubsets.Add(BarcodeSymbologySubsets.FedExGround96);
            settings.ScanBarcodeSubsets.Add(BarcodeSymbologySubsets.GS1Aztec);
            settings.ScanBarcodeSubsets.Add(BarcodeSymbologySubsets.GS1DataBar);
            settings.ScanBarcodeSubsets.Add(BarcodeSymbologySubsets.GS1DataBarExpanded);
            settings.ScanBarcodeSubsets.Add(BarcodeSymbologySubsets.GS1DataBarExpandedStacked);
            settings.ScanBarcodeSubsets.Add(BarcodeSymbologySubsets.GS1DataBarLimited);
            settings.ScanBarcodeSubsets.Add(BarcodeSymbologySubsets.GS1DataBarStacked);
            settings.ScanBarcodeSubsets.Add(BarcodeSymbologySubsets.GS1DataMatrix);
            settings.ScanBarcodeSubsets.Add(BarcodeSymbologySubsets.GS1QR);
            settings.ScanBarcodeSubsets.Add(BarcodeSymbologySubsets.GS1_128);
            settings.ScanBarcodeSubsets.Add(BarcodeSymbologySubsets.Interleaved2of5ChecksumISO16390);
            settings.ScanBarcodeSubsets.Add(BarcodeSymbologySubsets.Interleaved2of5ChecksumMod10C);
            settings.ScanBarcodeSubsets.Add(BarcodeSymbologySubsets.ISBN);
            settings.ScanBarcodeSubsets.Add(BarcodeSymbologySubsets.ISBNPlus2);
            settings.ScanBarcodeSubsets.Add(BarcodeSymbologySubsets.ISBNPlus5);
            settings.ScanBarcodeSubsets.Add(BarcodeSymbologySubsets.ISMN);
            settings.ScanBarcodeSubsets.Add(BarcodeSymbologySubsets.ISMNPlus2);
            settings.ScanBarcodeSubsets.Add(BarcodeSymbologySubsets.ISMNPlus5);
            settings.ScanBarcodeSubsets.Add(BarcodeSymbologySubsets.ISSN);
            settings.ScanBarcodeSubsets.Add(BarcodeSymbologySubsets.ISSNPlus2);
            settings.ScanBarcodeSubsets.Add(BarcodeSymbologySubsets.ISSNPlus5);
            settings.ScanBarcodeSubsets.Add(BarcodeSymbologySubsets.ITF14);
            settings.ScanBarcodeSubsets.Add(BarcodeSymbologySubsets.JAN13);
            settings.ScanBarcodeSubsets.Add(BarcodeSymbologySubsets.JAN13Plus2);
            settings.ScanBarcodeSubsets.Add(BarcodeSymbologySubsets.JAN13Plus5);
            settings.ScanBarcodeSubsets.Add(BarcodeSymbologySubsets.JAN8);
            settings.ScanBarcodeSubsets.Add(BarcodeSymbologySubsets.JAN8Plus2);
            settings.ScanBarcodeSubsets.Add(BarcodeSymbologySubsets.JAN8Plus5);
            settings.ScanBarcodeSubsets.Add(BarcodeSymbologySubsets.MailmarkCmdmType29);
            settings.ScanBarcodeSubsets.Add(BarcodeSymbologySubsets.MailmarkCmdmType7);
            settings.ScanBarcodeSubsets.Add(BarcodeSymbologySubsets.MailmarkCmdmType9);
            settings.ScanBarcodeSubsets.Add(BarcodeSymbologySubsets.NumlyNumber);
            settings.ScanBarcodeSubsets.Add(BarcodeSymbologySubsets.OPC);
            settings.ScanBarcodeSubsets.Add(BarcodeSymbologySubsets.PPN);
            settings.ScanBarcodeSubsets.Add(BarcodeSymbologySubsets.PZN);
            settings.ScanBarcodeSubsets.Add(BarcodeSymbologySubsets.SSCC18);
            settings.ScanBarcodeSubsets.Add(BarcodeSymbologySubsets.SwissPostParcel);
            settings.ScanBarcodeSubsets.Add(BarcodeSymbologySubsets.VicsBol);
            settings.ScanBarcodeSubsets.Add(BarcodeSymbologySubsets.VicsScacPro);
            settings.ScanBarcodeSubsets.Add(BarcodeSymbologySubsets.VIN);
            settings.ScanBarcodeSubsets.Add(BarcodeSymbologySubsets.XFACompressedAztec);
            settings.ScanBarcodeSubsets.Add(BarcodeSymbologySubsets.XFACompressedDataMatrix);
            settings.ScanBarcodeSubsets.Add(BarcodeSymbologySubsets.XFACompressedPDF417);
            settings.ScanBarcodeSubsets.Add(BarcodeSymbologySubsets.XFACompressedQRCode);
        }
    }
}
