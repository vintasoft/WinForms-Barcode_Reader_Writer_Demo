using System.Collections;
using System.Text;
using Vintasoft.Barcode;
using Vintasoft.Barcode.SymbologySubsets;

namespace BarcodeDemo
{
    public class BarcodesInformation
    {

        #region Fields

        const string NewLine = "\r\n";
        const string AllowableCharacters = NewLine + NewLine + "Allowable characters: ";
        const string ASCIISymbols = "standard ASCII symbols(0..127)";
        const string ExtendedASCIISymbols = ", extended ASCII symbols(128..255)";
        const string Digits = "digits 0-9";
        const string LettersAZ = "letters A-Z(upper case only)";
        const string CheckSumOptional = NewLine + NewLine + "It has optional Checksum!";
        const string NoCheckSum = NewLine + NewLine + "There is no checksum!";
        const string MinMaxForPostal = NewLine + NewLine + "Barcode must contain min 5 and max 40 digits.";

        static Hashtable _info = new Hashtable();

        #endregion



        #region Constructors

        static BarcodesInformation()
        {
            StringBuilder text = new StringBuilder();

            // Code128
            text.Length = 0; 
            text.Append("Code 128 symbology has been widely implemented in many applications where a relatively large amount of data must be encoded in a relatively small amount of space. It's a very effective, high-density barcode. Supported modes: A, B, C(auto detect).");
            text.Append(AllowableCharacters);
            text.Append(ASCIISymbols);
            text.Append(ExtendedASCIISymbols);
            text.Append(NewLine);
            text.Append(NewLine);
            text.Append(" - Special symbols: " + NewLine);
            text.Append(" 1. <FNC1> - FNC1 flag" + NewLine);
            text.Append(" 2. <FNC2> - FNC2 flag" + NewLine);
            text.Append(" 3. <FNC3> - FNC3 flag" + NewLine);
            text.Append(" 4. <FNC4> - FNC4 flag (shift to extended ASCII table)" + NewLine);
            _info.Add(BarcodeType.Code128,  text.ToString());

            // GS1-128 
            text.Length = 0;
            text.Append("GS1-128 (UCC/EAN-128, EAN-128) is subset of Code 128 symbology. The Bar Code has been carefully designed through joint co-operation between GS1 and AIM." + NewLine);
            text.Append("Value specifies in GS1 format (GS1ValueItem).");
            _info.Add(BarcodeSymbologySubsets.GS1_128, text.ToString());

            // SSCC-18 
            text.Length = 0;
            text.Append("SSCC-18 is subset of GS1-128 symbology." + NewLine);
            text.Append("Encodes 18-digits SSCC (Serial Shipping Container Code).");
            _info.Add(BarcodeSymbologySubsets.SSCC18, text.ToString());

            // FedEx Ground 96 
            text.Length = 0;
            text.Append("FedEx Ground 96 is subset of GS1-128 symbology." + NewLine);
            text.Append("Value constains 21 or 22 digits. Value starts with two-digit number '96'.");
            _info.Add(BarcodeSymbologySubsets.FedExGround96, text.ToString());

            // VICS BOL
            text.Length = 0;
            text.Append("VICS BOL (VICS Bill of Lading) is subset of GS1-128 symbology." + NewLine);
            text.Append("Value constains 16 or 17 digits.");
            _info.Add(BarcodeSymbologySubsets.VicsBol, text.ToString());

            // VICS SCAC RPO
            text.Length = 0;
            text.Append("VICS SCAC PRO (SCAC/Pro Barcode, Standard Carrier Alpha Code) is subset of GS1-128 symbology." + NewLine);
            text.Append("Barcode value example: SCAC01234567890123456789.");
            _info.Add(BarcodeSymbologySubsets.VicsScacPro, text.ToString());

            // Code39
            text.Length = 0;
            text.Append("Code 39 is the first symbology developed for coding alpha-numeric. It's still widely used - especially in non-retail environments.");
            text.Append(AllowableCharacters);
            text.Append("'0'..'9', 'A'..'Z', '-', '.', ' ', '$', '/', '%'");
            text.Append(CheckSumOptional);
            _info.Add(BarcodeType.Code39, text.ToString());

            // Code39 Extended
            text.Length = 0;
            text.Append("Code 39 Extended is subset of Code 39 symbology.");
            text.Append(AllowableCharacters);
            text.Append(ASCIISymbols);
            text.Append(CheckSumOptional);
            _info.Add(BarcodeSymbologySubsets.Code39Extended, text.ToString());

            // Code32
            text.Length = 0;
            text.Append("Code 32 (Italian Pharmacode, Codice 32 Pharmacode) is subset of Code 39 symbology, encodes 8 digits and one check digit.");
            text.Append(AllowableCharacters); 
            text.Append(Digits);
            _info.Add(BarcodeSymbologySubsets.Code32, text.ToString());

            // VIN
            text.Length = 0;
            text.Append("VIN is subset of Code 39 symbology, encodes Vehicle Identification Number.");
            text.Append(AllowableCharacters);
            text.Append("0..9, A..Z, exclude I,Q,O.");
            text.Append("Value must contain 17 characters.");
            _info.Add(BarcodeSymbologySubsets.VIN, text.ToString());

            // DHL AWB
            text.Length = 0;
            text.Append("DHL AWB is subset of Code 39 symbology.");
            text.Append(AllowableCharacters);
            text.Append(Digits + NewLine);
            text.Append("Value must contain 9 or 10 digits.");
            _info.Add(BarcodeSymbologySubsets.DhlAwb, text.ToString());

            // PZN
            text.Length = 0;
            text.Append("PZN (Pharmazentralnummer, Pharma-Zentral-Nummer, Code PZN, CodePZN, PZN7, PZN8) is subset of Code 39 symbology, used for distribution of pharmaceutical or health care products in Germany.");
            text.Append(AllowableCharacters);
            text.Append("0..9"+NewLine);
            text.Append("Value must contain 6 (PZN7) or 7 (PZN8) digits.");
            _info.Add(BarcodeSymbologySubsets.PZN, text.ToString());

            // NumlyNumber
            text.Length = 0;
            text.Append("Numly Number (ESN, Electronic Serial Number) is subset of Code 39 symbology.");
            text.Append("The Numly Number consists of a 19 digit number generated by an algorithm maintained by Numly.com.");
            text.Append(AllowableCharacters);
            text.Append(Digits);
            _info.Add(BarcodeSymbologySubsets.NumlyNumber, text.ToString());

            // EAN13
            text.Length = 0;
            text.Append("EAN-13 symbology, based upon the UPC-A standard."); 
            text.Append(AllowableCharacters); 
            text.Append(Digits); 
            text.Append(". Value must contain 12 digits.");
            _info.Add(BarcodeType.EAN13, text.ToString());

            // EAN13Plus2
            text.Length = 0;
            text.Append("EAN-13 with a 2 digit add-on.");
            text.Append(AllowableCharacters);
            text.Append(Digits);
            text.Append(". Value should be in format: 'NNNNNNNNNNNN NN'.");
            _info.Add(BarcodeType.EAN13Plus2, text.ToString());

            // EAN13Plus5
            text.Length = 0;
            text.Append("EAN-13 with a 5 digit add-on.");
            text.Append(AllowableCharacters);
            text.Append(Digits);
            text.Append(". Value should be in format: 'NNNNNNNNNNNN NNNNN'.");
            _info.Add(BarcodeType.EAN13Plus5, text.ToString());

            // EAN8
            text.Length = 0;
            text.Append("EAN-8, based upon the UPC-A standard.");
            text.Append(AllowableCharacters); 
            text.Append(Digits); 
            text.Append(". Value must contain 7 digits.");
            _info.Add(BarcodeType.EAN8, text.ToString());

            // EAN8Plus2
            text.Length = 0;
            text.Append("EAN-8 with a 2 digit add-on.");
            text.Append(AllowableCharacters);
            text.Append(Digits);
            text.Append(". Value should be in format: 'NNNNNNN NN'.");
            _info.Add(BarcodeType.EAN8Plus2, text.ToString());

            // EAN8Plus5
            text.Length = 0;
            text.Append("EAN-8 with a 5 digit add-on.");
            text.Append(AllowableCharacters);
            text.Append(Digits);
            text.Append(". Value should be in format: 'NNNNNNN NNNNN'.");
            _info.Add(BarcodeType.EAN8Plus5, text.ToString());

            // JAN13
            text.Length = 0;
            text.Append("JAN13 is subset of EAN13 symbology, for JAN barcodes the first two digits must be 45 or 49 which identifies Japan.");
            text.Append(AllowableCharacters);
            text.Append(Digits);
            text.Append(". Value must contain 12 digits.");
            _info.Add(BarcodeSymbologySubsets.JAN13, text.ToString());

            // JAN13+2
            text.Length = 0;
            text.Append("JAN13 with a 2 digit add-on. For JAN barcodes the first two digits must be 45 or 49 which identifies Japan.");
            text.Append(AllowableCharacters);
            text.Append(Digits);
            text.Append(". Value should be in format: 'NNNNNNNNNNNN NN'.");
            _info.Add(BarcodeSymbologySubsets.JAN13Plus2, text.ToString());

            // JAN13+5
            text.Length = 0;
            text.Append("JAN13 with a 5 digit add-on. For JAN barcodes the first two digits must be 45 or 49 which identifies Japan.");
            text.Append(AllowableCharacters);
            text.Append(Digits);
            text.Append(". Value should be in format: 'NNNNNNNNNNNN NNNNN'.");
            _info.Add(BarcodeSymbologySubsets.JAN13Plus5, text.ToString());

            // JAN8
            text.Length = 0;
            text.Append("JAN8 is subset of EAN8 symbology, for JAN barcodes the first two digits must be 45 or 49 which identifies Japan.");
            text.Append(AllowableCharacters);
            text.Append(Digits);
            text.Append(". Value must contain 7 digits.");
            _info.Add(BarcodeSymbologySubsets.JAN8, text.ToString());

            // JAN8+2
            text.Length = 0;
            text.Append("JAN8 with a 2 digit add-on. For JAN barcodes the first two digits must be 45 or 49 which identifies Japan.");
            text.Append(AllowableCharacters);
            text.Append(Digits);
            text.Append(". Value should be in format: 'NNNNNNN NN'.");
            _info.Add(BarcodeSymbologySubsets.JAN8Plus2, text.ToString());

            // JAN8+5
            text.Length = 0;
            text.Append("JAN8 with a 5 digit add-on. For JAN barcodes the first two digits must be 45 or 49 which identifies Japan.");
            text.Append(AllowableCharacters);
            text.Append(Digits);
            text.Append(". Value should be in format: 'NNNNNNN NNNNN'.");
            _info.Add(BarcodeSymbologySubsets.JAN8Plus5, text.ToString());

            // ISBN
            text.Length = 0;
            text.Append("ISBN is subset of EAN13 symbology, encodes a unique identifier assigned to each edition of every published book and book-like product. For ISBN barcodes the first three digits must be 978 or 979. ");
            text.Append(AllowableCharacters);
            text.Append(Digits);
            text.Append(". Value must contain 13 (ISBN13) or 10 (ISBN10) digits.");
            _info.Add(BarcodeSymbologySubsets.ISBN, text.ToString());

            // ISBN+2
            text.Length = 0;
            text.Append("ISBN with a 2 digit add-on.");
            text.Append(AllowableCharacters);
            text.Append(Digits);
            text.Append(". Value must contain 13 (ISBN13) or 10 (ISBN10) digits and two digits add-on.");
            _info.Add(BarcodeSymbologySubsets.ISBNPlus2, text.ToString());

            // ISBN+2
            text.Length = 0;
            text.Append("ISBN with a 5 digit add-on.");
            text.Append(AllowableCharacters);
            text.Append(Digits);
            text.Append(". Value must contain 13 (ISBN13) or 10 (ISBN10) digits and five digits add-on.");
            _info.Add(BarcodeSymbologySubsets.ISBNPlus5, text.ToString());


            // ISMN
            text.Length = 0;
            text.Append("ISMN is subset of EAN13 symbology, encodes International Standard Music Number. For ISMN13 barcodes the first four digits must be 9790. ");
            text.Append(AllowableCharacters);
            text.Append(Digits);
            text.Append(". Value format is ISMN13 (979-0-060-11561-5) or ISMN (M-060-11561-5).");
            _info.Add(BarcodeSymbologySubsets.ISMN, text.ToString());

            // ISMN+2
            text.Length = 0;
            text.Append("ISMN with a 2 digit add-on.");
            text.Append(AllowableCharacters);
            text.Append(Digits);
            text.Append(". Value format is ISMN13 (979-0-060-11561-5) or ISMN (M-060-11561-5) and two digits add-on.");
            _info.Add(BarcodeSymbologySubsets.ISMNPlus2, text.ToString());

            // ISMN+2
            text.Length = 0;
            text.Append("ISMN with a 5 digit add-on.");
            text.Append(AllowableCharacters);
            text.Append(Digits);
            text.Append(". Value format is ISMN13 (979-0-060-11561-5) or ISMN (M-060-11561-5) and five digits add-on.");
            _info.Add(BarcodeSymbologySubsets.ISMNPlus5, text.ToString());

            // ISSN
            text.Length = 0;
            text.Append("ISSN is subset of EAN13 symbology, encodes International Standard Serial Number. For ISSN barcodes the first three digits must be 977. ");
            text.Append(AllowableCharacters);
            text.Append(Digits);
            text.Append(". Value format is ISSN (1812-1896).");
            _info.Add(BarcodeSymbologySubsets.ISSN, text.ToString());

            // ISSN+2
            text.Length = 0;
            text.Append("ISSN with a 2 digit add-on.");
            text.Append(AllowableCharacters);
            text.Append(Digits);
            text.Append(". Value format is ISSN (1812-1896) and two digits add-on.");
            _info.Add(BarcodeSymbologySubsets.ISSNPlus2, text.ToString());

            // ISSN+2
            text.Length = 0;
            text.Append("ISSN with a 5 digit add-on.");
            text.Append(AllowableCharacters);
            text.Append(Digits);
            text.Append(". Value format is ISSN (1812-1896) and five digits add-on.");
            _info.Add(BarcodeSymbologySubsets.ISSNPlus5, text.ToString());

            // EAN-Velocity
            text.Length = 0;
            text.Append("EAN-Velocity is a special version of EAN-8, with the first digit is 0 (zero) which is usually used for internal article numbering.");
            text.Append(AllowableCharacters);
            text.Append(Digits);
            text.Append(". Value must contain 6 or 7 digits.");
            _info.Add(BarcodeSymbologySubsets.EANVelocity, text.ToString());

            // UPCA
            text.Length = 0;
            text.Append("UPC-A symbology. "); 
            text.Append(AllowableCharacters); 
            text.Append(Digits); 
            text.Append(". Value must contain 12 digits.");
            _info.Add(BarcodeType.UPCA, text.ToString());

            // UPCAPlus2
            text.Length = 0;
            text.Append("UPC-A with a 2 digit add-on.");
            text.Append(AllowableCharacters);
            text.Append(Digits);
            text.Append(". Value should be in format: 'NNNNNNNNNNNN NN'.");
            _info.Add(BarcodeType.UPCAPlus2, text.ToString());

            // UPCAPlus5
            text.Length = 0;
            text.Append("UPC-A with a 5 digit add-on.");
            text.Append(AllowableCharacters);
            text.Append(Digits);
            text.Append(". Value should be in format: 'NNNNNNNNNNNN NNNNN'.");
            _info.Add(BarcodeType.UPCAPlus5, text.ToString());

            // UPCE
            text.Length = 0;
            text.Append("UPC-E is a variation of UPC-A, UPC-E is more compact than UPC-A because \"extra\" zeros are eliminated."); 
            text.Append(AllowableCharacters); 
            text.Append(Digits); 
            text.Append(". Value must contain 6, 10 or 12 digits.");            
            _info.Add(BarcodeType.UPCE, text.ToString());

            // UPCEPlus2
            text.Length = 0;
            text.Append("UPC-E with a 2 digit add-on.");
            text.Append(AllowableCharacters);
            text.Append(Digits);
            text.Append(". Value should be in format: 'NNNNNN NN'.");
            _info.Add(BarcodeType.UPCEPlus2, text.ToString());

            // UPCEPlus5
            text.Length = 0;
            text.Append("UPC-E with a 5 digit add-on.");
            text.Append(AllowableCharacters);
            text.Append(Digits);
            text.Append(". Value should be in format: 'NNNNNN NNNNN'.");
            _info.Add(BarcodeType.UPCEPlus5, text.ToString());

            // Code93
            text.Length = 0;
            text.Append("Code 93 symbology was designed to complement and improve Code 39. "); 
            text.Append(AllowableCharacters); 
            text.Append(LettersAZ); 
            text.Append(", "); 
            text.Append(Digits); 
            text.Append(", space, '-', '+', '.', '$', '/', '%'.");
            _info.Add(BarcodeType.Code93, text.ToString()); 

            // Code11
            text.Length = 0;
            text.Append("Code 11 symbology was developed as high-density numeric-only symbology. "); 
            text.Append(AllowableCharacters); 
            text.Append(Digits); 
            text.Append(" and dash symbol '-'.");
            _info.Add(BarcodeType.Code11, text.ToString());

            // MSI
            text.Length = 0;
            text.Append("MSI was developed by the MSI Data Corporation, based on the original Plessey Code. MSI, also known as Modified Plessey, is used primarily to mark retail shelves for inventory control. ");
            text.Append(AllowableCharacters);
            text.Append(Digits);
            _info.Add(BarcodeType.MSI, text.ToString());

            // Codabar
            text.Length = 0;
            text.Append("Codabar was developed in 1972 by Pitney Biwes Inc."); 
            text.Append(AllowableCharacters); text.Append(Digits); 
            text.Append(", '-', '$', ':', '/', '.', '+'. Start/Stop characters: A,B,C,D."); 
            text.Append(NoCheckSum);
            _info.Add(BarcodeType.Codabar, text.ToString());

            // Standard2of5
            text.Length = 0;
            text.Append("Standard 2 of 5 is a low-density numeric symbology developed in the 1960s.");
            text.Append(AllowableCharacters);
            text.Append(Digits); 
            text.Append("."); 
            text.Append(CheckSumOptional);
            _info.Add(BarcodeType.Standard2of5, text.ToString());

            // IATA 2 of 5
            text.Length = 0;
            text.Append("IATA 2 of 5 barcode is used by International Air Transport Association (IATA) for the management of air transport.");
            text.Append(AllowableCharacters);
            text.Append(Digits);
            text.Append(".");
            _info.Add(BarcodeType.IATA2of5, text.ToString());

            // Matrix 2 of 5
            text.Length = 0;
            text.Append("Matrix 2 of 5 barcode symbology.");
            text.Append(AllowableCharacters);
            text.Append(Digits);
            text.Append(".");
            text.Append(CheckSumOptional);
            _info.Add(BarcodeType.Matrix2of5, text.ToString());

            // Interleaved2of5
            text.Length = 0;
            text.Append("Interleaved 2 of 5 is a higher-density numeric symbology based upon the Standard 2 of 5.");
            text.Append(AllowableCharacters);
            text.Append(Digits); text.Append("."); text.Append(NewLine);
            text.Append(CheckSumOptional);
            _info.Add(BarcodeType.Interleaved2of5, text.ToString());

            // Swiss PostParcel
            text.Length = 0;
            text.Append("Swiss PostParcel is subset of Code 128 symbology." + NewLine);
            text.Append(AllowableCharacters);
            text.Append(Digits); text.Append("."); text.Append(NewLine);
            text.Append("Value must contain 18 digits.");
            _info.Add(BarcodeSymbologySubsets.SwissPostParcel, text.ToString());


            // ITF-14 
            text.Length = 0;
            text.Append("ITF-14 is subset of Interleaved 2 of 5 symbology, encodes value in GS1 System data format with GTIN('01') application idetifier." + NewLine);
            text.Append("Value specifies in GS1 format (GS1ValueItem).");
            _info.Add(BarcodeSymbologySubsets.ITF14, text.ToString());

            // OPC
            text.Length = 0;
            text.Append("OPC is subset of Interleaved 2 of 5 symbology, encodes Optical Product Code.");
            text.Append(AllowableCharacters);
            text.Append(Digits); text.Append("."); text.Append(NewLine);
            text.Append("Value must contain 9 characters.");
            _info.Add(BarcodeSymbologySubsets.OPC, text.ToString());

            // DeutschePostIdentcode
            text.Length = 0;
            text.Append("Deutsche Post Identcode is subset of Interleaved 2 of 5 symbology, encodes a tracking number providing an identification of the customer (sender) and the mail piece.");
            text.Append(AllowableCharacters);
            text.Append(Digits); text.Append("."); text.Append(NewLine);
            text.Append("Value must contain 11 digits (check digit calaculated automatically).");
            _info.Add(BarcodeSymbologySubsets.DeutschePostIdentcode, text.ToString());

            // DeutschePostLeitcode
            text.Length = 0;
            text.Append("Deutsche Post Leitcode is subset of Interleaved 2 of 5 symbology, encodes an indication of the destination.");
            text.Append(AllowableCharacters);
            text.Append(Digits); text.Append("."); text.Append(NewLine);
            text.Append("Value must contain 13 digits (check digit calaculated automatically).");
            _info.Add(BarcodeSymbologySubsets.DeutschePostLeitcode, text.ToString());

            // Telepen
            text.Length = 0;
            text.Append("Telepen is a compact barcode symbology developed in 1972. Double density in numeric only mode."); 
            text.Append(AllowableCharacters); 
            text.Append(ASCIISymbols);
            text.Append(".");
            _info.Add(BarcodeType.Telepen, text.ToString());

            // PatchCode
            text.Length = 0;
            text.Append("Patch code was developed by Kodak specially for batch jobs.");
            text.Append(AllowableCharacters);
            text.Append(" 1, 2, 3, 4, 6 or T.");
            _info.Add(BarcodeType.PatchCode, text.ToString());

            // Pharmacode
            text.Length = 0;
            text.Append("Pharmacode is a barcode standard, used in the pharmaceutical industry as a packing control system. Pharmacode can contains only a single integer from 16 to 131069.");
            _info.Add(BarcodeType.Pharmacode, text.ToString());

            // AustralianPost
            text.Length = 0;
            text.Append("Australian Post 4-State symbology."); 
            text.Append(AllowableCharacters); 
            text.Append(Digits);
            text.Append(".\n\nValue must contain at least 10 digits.\nFirst two digits can be 11, 87, 45, 92, 59, 62, 44.");
            _info.Add(BarcodeType.AustralianPost, text.ToString());

            // IntelligentMail
            text.Length = 0;
            text.Append("Intelligent Mail postal symbology."); 
            text.Append(AllowableCharacters);
            text.Append(Digits);
            text.Append(".\n\nValue must contain 20, 25, 29 or 31 digits. Second digit must be 0-4.");
            _info.Add(BarcodeType.IntelligentMail, text.ToString());

            // Planet
            text.Length = 0;
            text.Append("Planet postal symbology."); 
            text.Append(AllowableCharacters); 
            text.Append(Digits); 
            text.Append("."); 
            text.Append(MinMaxForPostal);
            _info.Add(BarcodeType.Planet, text.ToString());

            // Postnet
            text.Length = 0;
            text.Append("Postnet postal symbology."); 
            text.Append(AllowableCharacters); 
            text.Append(Digits); 
            text.Append("."); 
            text.Append(MinMaxForPostal);
            _info.Add(BarcodeType.Postnet, text.ToString());

            // RoyalMail
            text.Length = 0;
            text.Append("RoyalMail postal symbology."); 
            text.Append(AllowableCharacters); 
            text.Append(Digits); 
            text.Append(", "); 
            text.Append(LettersAZ); 
            text.Append("."); 
            text.Append(MinMaxForPostal);
            _info.Add(BarcodeType.RoyalMail, text.ToString());

            // DutchKIX
            text.Length = 0;
            text.Append("Dutch KIX postal symbology.");
            text.Append(AllowableCharacters);
            text.Append(Digits);
            text.Append(", ");
            text.Append(LettersAZ);
            text.Append(".");
            text.Append(MinMaxForPostal);
            _info.Add(BarcodeType.DutchKIX, text.ToString());
            
            // Mailmark 4-state C
            text.Length = 0;
            text.AppendLine("Royal Mail Mailmark 4-state barcode C symbology.");
            text.AppendLine("Value length: 22 symbols.");
            text.AppendLine("Value format see in 'Royal Mail Mailmark barcode definition document v3.0'");
            text.AppendLine("Value example: '1100000000000XY11     ', '21B2254800659JW5O9QA6Y'");
            _info.Add(BarcodeType.Mailmark4StateC, text.ToString());

            // Mailmark 4-state L
            text.Length = 0;
            text.AppendLine("Royal Mail Mailmark 4-state barcode L symbology.");
            text.AppendLine("Value length: 26 symbols.");
            text.AppendLine("Value format see in 'Royal Mail Mailmark barcode definition document v3.0'");
            text.AppendLine("Value example: '11000000000000000XY11     ', '41038422416563762EF61AH8T ', '11224689598765432EC1V9HQ6W'");
            _info.Add(BarcodeType.Mailmark4StateL, text.ToString());
            
            // RSS14
            text.Length = 0;
            text.Append("RSS-14 barcode symbology (ISO 24724)."); 
            text.Append(AllowableCharacters); 
            text.Append(Digits); 
            text.Append("."); 
            text.Append("Value must contain 13 digits."); 
            text.Append(NewLine);
            text.Append("RSS-14:"); 
            text.Append(NewLine);
            text.Append("  Minimum Symbol Height: 33X"); 
            text.Append(NewLine); 
            text.Append("RSS-14 Truncated:"); 
            text.Append(NewLine); 
            text.Append("  Minimum Symbol Height: 13X"); 
            text.Append(NewLine); 
            text.Append("  Maximum Symbol Height: 33X"); 
            _info.Add(BarcodeType.RSS14, text.ToString());

            // GS1DataBar
            text.Length = 0;
            text.Append("GS1 DataBar is subset of RSS14 symbology, encodes value in GS1 System data format with GTIN('01') application idetifier.");
            _info.Add(BarcodeSymbologySubsets.GS1DataBar, text.ToString());

            // GS1DataBarExpanded
            text.Length = 0;
            text.Append("GS1 DataBar Expanded is subset of RSS Expanded symbology, encodes value in GS1 System data format.");
            _info.Add(BarcodeSymbologySubsets.GS1DataBarExpanded, text.ToString());

            // GS1DataBarExpandedStacked
            text.Length = 0;
            text.Append("GS1 DataBar Expanded Stacked is subset of RSS Expanded Stacked symbology, encodes value in GS1 System data format.");
            _info.Add(BarcodeSymbologySubsets.GS1DataBarExpandedStacked, text.ToString());

            // GS1DataBarLimited
            text.Length = 0;
            text.Append("GS1 DataBar Limited is subset of RSS Limited symbology, encodes value in GS1 System data format with GTIN('01') application idetifier.");
            _info.Add(BarcodeSymbologySubsets.GS1DataBarLimited, text.ToString());

            // GS1DataBarStacked
            text.Length = 0;
            text.Append("GS1 DataBar Limited is subset of RSS14 Stacked symbology, encodes value in GS1 System data format with GTIN('01') application idetifier.");
            _info.Add(BarcodeSymbologySubsets.GS1DataBarStacked, text.ToString());

            // GS1 Aztec
            text.Length = 0;
            text.Append("GS1 Aztec is subset of Aztec symbology, encodes value in GS1 System data format.");
            _info.Add(BarcodeSymbologySubsets.GS1Aztec, text.ToString());

            // GS1 DataMatrix
            text.Length = 0;
            text.Append("GS1 DataMatrix is subset of DataMatrix symbology, encodes value in GS1 System data format.");
            _info.Add(BarcodeSymbologySubsets.GS1DataMatrix, text.ToString());

            // GS1 QR
            text.Length = 0;
            text.Append("GS1 QR is subset of QR Code symbology, encodes value in GS1 System data format.");
            _info.Add(BarcodeSymbologySubsets.GS1QR, text.ToString());

            // XFA Compressed Aztec
            text.Length = 0;
            text.Append("The Aztec barcode symbology subset with barcode values, which are compressed as defined in Adobe XFA Specification.");
            _info.Add(BarcodeSymbologySubsets.XFACompressedAztec, text.ToString());

            // XFA Compressed DataMatrix
            text.Length = 0;
            text.Append("The DataMatrix barcode symbology subset with barcode values, which are compressed as defined in Adobe XFA Specification.");
            _info.Add(BarcodeSymbologySubsets.XFACompressedDataMatrix, text.ToString());

            // XFA Compressed PDF417
            text.Length = 0;
            text.Append("The PDF417 barcode symbology subset with barcode values, which are compressed as defined in Adobe XFA Specification.");
            _info.Add(BarcodeSymbologySubsets.XFACompressedPDF417, text.ToString());

            // XFA Compressed QRCode
            text.Length = 0;
            text.Append("The QR barcode symbology subset with barcode values, which are compressed as defined in Adobe XFA Specification.");
            _info.Add(BarcodeSymbologySubsets.XFACompressedQRCode, text.ToString());


            // RSS14Stacked
            text.Length = 0;
            text.Append("RSS-14 Stacked (2 rows) barcode symbology (ISO 24724). "); 
            text.Append(AllowableCharacters); 
            text.Append(Digits); 
            text.Append("."); 
            text.Append("Value must contain 13 digits."); 
            text.Append(NewLine); 
            text.Append("RSS-14 Stacked:"); 
            text.Append(NewLine); 
            text.Append("  Minimum Symbol Height: 13X"); 
            text.Append(NewLine); 
            text.Append("RSS-14 Stacked Omnidirectional:"); 
            text.Append(NewLine); 
            text.Append("  Minimum Symbol Height: 69X"); 
            _info.Add(BarcodeType.RSS14Stacked, text.ToString());

            // RSSLimited
            text.Length = 0;
            text.Append("RSS Limited barcode symbology (ISO 24724). ");
            text.Append(AllowableCharacters); 
            text.Append(Digits); 
            text.Append(".");
            text.Append("Value must contain 13 digits."); 
            text.Append(NewLine); 
            text.Append("  Minimum Symbol Height: 10X"); 
            _info.Add(BarcodeType.RSSLimited, text.ToString());

            // RSSExpanded
            text.Length = 0;
            text.Append("RSS Expanded barcode symbology (ISO 24724)."); 
            text.Append(AllowableCharacters); 
            text.Append(ASCIISymbols);
            text.Append(""); 
            text.Append(NewLine);
            text.Append("  Minimum Symbol Height: 34X");
            text.Append(NewLine);
            text.Append(" - Special symbols: "); 
            text.Append(NewLine); 
            text.Append(" 1. <FNC1> - FNC1 flag"); 
            _info.Add(BarcodeType.RSSExpanded, text.ToString());

            // RSSExpandedStacked
            text.Length = 0;
            text.Append("RSS Expanded Stacked(2-11 rows) barcode symbology (ISO 24724).");
            text.Append(AllowableCharacters); text.Append(ASCIISymbols);
            text.Append(NewLine); 
            text.Append("  Minimum Symbol Height: 71X(2 row) - 404X(11 row)");
            text.Append(NewLine);
            text.Append(" - Special symbols: ");
            text.Append(NewLine); 
            text.Append(" 1. <FNC1> - FNC1 flag");            
            _info.Add(BarcodeType.RSSExpandedStacked, text.ToString());

            // Aztec
            text.Length = 0;
            text.Append("Aztec is a two-dimensional barcode symbology."); 
            text.Append(NewLine);
            text.Append(" - ISO/IEC 24778:2008(E)"); 
            text.Append(NewLine); 
            text.Append(" - Text/Byte modes"); 
            text.Append(NewLine); 
            text.Append(" - Reed-Solomon error detection and correction (0%..99%)");
            text.Append(NewLine); 
            text.Append(NewLine); 
            text.Append(" - Special symbols: "); 
            text.Append(NewLine); 
            text.Append(" 1. <FNC1> - FNC1 flag");
            text.Append(NewLine);
            text.Append(" 2. <ECInnnnnn> - ECI character (n=0..9)");
            text.Append(NewLine);
            text.Append(" 3. <SA_n_m> - Structured Append character (n - symbol position, m - symbol count). See AztecStructureAppendCharacter class.");
            _info.Add(BarcodeType.Aztec, text.ToString());

            // DataMatrix
            text.Length = 0;
            text.Append("Data Matrix is a two-dimensional barcode symbology."); 
            text.Append(NewLine); 
            text.Append(" - ISO/IEC 16022:2006(E)"); 
            text.Append(NewLine); 
            text.Append(" - Three data encoding modes:"); 
            text.Append(NewLine); 
            text.Append(" 1. Alphanumeric(up to 2335 characters)"); 
            text.Append(NewLine); 
            text.Append(" 2. Byte(up to 1555 bytes)");
            text.Append(NewLine); 
            text.Append(" 3. Numeric(up to 3116 digits)"); 
            text.Append(NewLine); 
            text.Append(" - Reed-Solomon error detection and correction"); 
            text.Append(NewLine);
            text.Append(NewLine);
            text.Append(" - Special symbols: "); 
            text.Append(NewLine); 
            text.Append(" 1. <FNC1> - FNC1 flag"); 
            text.Append(NewLine); 
            text.Append(" 2. <ECInnnnnn> - ECI character (n=0..9)");
            text.Append(NewLine);
            text.Append(" 3. <SA_n_m> - Structured Append character (n - symbol position, m - symbol count). See DataMatrixStructureAppendCharacter class.");
            text.Append(NewLine);
            text.Append(" 4. <MACRO_05> - Macro05 flag");
            text.Append(NewLine); 
            text.Append(" 5. <MACRO_06> - Macro06 flag");
            text.Append(NewLine);
            text.Append(" 6. <READER_PROGRAMMING> - Reader Programming character");            
            _info.Add(BarcodeType.DataMatrix, text.ToString()); 

            // QR
            text.Length = 0;
            text.Append("QR Code is a two-dimensional barcode symbology."); 
            text.Append(NewLine); 
            text.Append(" - ISO/IEC 18004:2006(E)"); 
            text.Append(NewLine);
            text.Append(" - Four data encoding modes:"); 
            text.Append(NewLine);
            text.Append(" 1. Alphanumeric(up to 4296 characters)");
            text.Append(NewLine);
            text.Append(" 2. Byte(up to 2953 bytes)"); 
            text.Append(NewLine); 
            text.Append(" 3. Numeric(up to 7089 digits)"); 
            text.Append(NewLine);
            text.Append(" 4. Kanji(up to 1817 characters)");
            text.Append(NewLine);
            text.Append(" - Reed-Solomon error detection and correction(4 levels)");
            text.Append(NewLine);
            text.Append(NewLine); 
            text.Append(" - Special symbols: ");
            text.Append(NewLine);
            text.Append(" 1. <FNC1> - FNC1 flag");
            text.Append(NewLine); 
            text.Append(" 2. <ECInnnnnn> - ECI character (n=0..9)");
            text.Append(NewLine);
            text.Append(" 3. <SA_n_m> - Structured Append character (n - symbol position, m - symbol count). See QRStructureAppendCharacter class.");
            text.Append(NewLine);
            _info.Add(BarcodeType.QR, text.ToString());

            // Micro QR
            text.Length = 0;
            text.Append("Micro QR Code is a two-dimensional barcode symbology.");
            text.Append(NewLine);
            text.Append(" - ISO/IEC 18004:2006(E)");
            text.Append(NewLine);
            text.Append(" - Four symbols:");
            text.Append(NewLine);
            text.Append(" M1: up to 5 Digits");
            text.Append(NewLine);
            text.Append(" M2: 10 Digits / 6 Alphanumeric characters");
            text.Append(NewLine);
            text.Append(" M3: 23 Digits / 14 Alphanumeric characters / 9 Bytes / 6 Kanji symbols");
            text.Append(NewLine);
            text.Append(" M4: 35 Digits / 21 Alphanumeric characters / 15 Bytes / 9 Kanji symbols");
            text.Append(NewLine);
            text.Append(" - Reed-Solomon error detection and correction(up to 3 levels)");
            _info.Add(BarcodeType.MicroQR, text.ToString());

            // MaxiCode
            text.Length = 0;
            text.Append("MaxiCode is a two-dimensional barcode symbology.");
            text.Append(NewLine);
            text.Append(" - ISO/IEC 16023:2000(E)");
            text.Append(NewLine);
            text.Append(" - Alphanumeric data(up to 93 text characters)");
            text.Append(NewLine);
            text.Append(" - Numeric data(up to 138 digits)");
            text.Append(NewLine);
            text.Append(" - Reed-Solomon error detection and correction(Mode2..Mode4,Mode6 - Standard; Mode5 - Extended)");
            text.Append(NewLine);
            text.Append(" - Special symbols: ");
            text.Append(NewLine);
            text.Append(" 1. <ECInnnnnn> - ECI character (n=0..9)");
            text.Append(NewLine);
            text.Append(" 2. <SA_n_m> - Structured Append character (n - symbol position, m - symbol count).");
            text.Append(NewLine);
            _info.Add(BarcodeType.MaxiCode, text.ToString()); 

            // PDF417
            text.Length = 0;
            text.Append("PDF417 is a two-dimensional barcode symbology."); 
            text.Append(NewLine);
            text.Append(" - ISO/IEC 15438:2006(E)");
            text.Append(NewLine); 
            text.Append(" - Three data encoding modes:");
            text.Append(NewLine);
            text.Append(" 1. Alphanumeric(up to 1850 characters)"); 
            text.Append(NewLine);
            text.Append(" 2. Byte(up to 1108 bytes)");
            text.Append(NewLine);
            text.Append(" 3. Numeric(up to 2710 digits)");
            text.Append(NewLine);
            text.Append(" - Reed-Solomon error detection and correction(9 levels)");
            text.Append(NewLine);
            text.Append(NewLine);
            text.Append(" - Special symbols: "); 
            text.Append(NewLine); 
            text.Append(" 1. <ECInnnnnn> - ECI character (n=0..9)");
            text.Append(NewLine);
            text.Append(" 2. <SA_n_m> - Structured Append character (n - symbol position, m - symbol count). See PDF417StructureAppendCharacter class.");
            text.Append(NewLine);
            text.Append(" 3. <LINKAGE> - linkage flag to composite symbol");
            text.Append(NewLine);
            text.Append(" 4. <LINKAGE_EANUCC> - linkage flag to EAN.UCC linear component");
            text.Append(NewLine);
            text.Append(" 5. <READER_PROGRAMMING> - Reader Programming character");            
            _info.Add(BarcodeType.PDF417, text.ToString());

            // PDF417Compact
            text.Length = 0;
            text.Append("PDF417 Compact is a two-dimension barcode symbology based on PDF417 barcode symbology. It does not contain stop symbol and right row indicator. \n\nFor more info see PDF417.");
            _info.Add(BarcodeType.PDF417Compact, text.ToString());

            // Micro PDF417
            text.Length = 0;
            text.Append("Micro PDF417 is a two-dimensional barcode symbology.");
            text.Append(NewLine);
            text.Append(" - ISO/IEC 24728:2006(E)");
            text.Append(NewLine);
            text.Append(" - Three data encoding modes:");
            text.Append(NewLine);
            text.Append(" 1. Alphanumeric(up to 250 characters)");
            text.Append(NewLine);
            text.Append(" 2. Byte(up to 150 bytes)");
            text.Append(NewLine);
            text.Append(" 3. Numeric(up to 366 digits)");
            text.Append(NewLine);
            text.Append(" - Reed-Solomon error detection and correction");
            text.Append(NewLine);
            text.Append(NewLine);
            text.Append(" - Special symbols: ");
            text.Append(NewLine);
            text.Append(" 1. <ECInnnnnn> - ECI character (n=0..9)");
            text.Append(NewLine);
            text.Append(" 2. <SA_n_m> - Structured Append character (n - symbol position, m - symbol count). See PDF417StructureAppendCharacter class.");
            text.Append(NewLine);
            text.Append(" 3. <LINKAGE> - linkage flag to composite symbol");
            text.Append(NewLine);
            text.Append(" 4. <LINKAGE_EANUCC> - linkage flag to EAN.UCC linear component");
            text.Append(NewLine);
            text.Append(" 5. <READER_PROGRAMMING> - Reader Programming character");
            text.Append(NewLine);
            text.Append(" 6. <MACRO_05> - Macro05 flag");
            text.Append(NewLine);
            text.Append(" 7. <MACRO_06> - Macro06 flag");
            text.Append(NewLine);
            text.Append(" 8. <CODE128EM_nnn> - Code128 emulation flag (nnn:903-912,914,915)");
            _info.Add(BarcodeType.MicroPDF417, text.ToString());

            // PPN
            text.Length = 0;
            text.Append("PPN (IFA PPN-Code, Pharmacy Product Number) is subset of DataMatrix symbology, encodes Pharmacy Product Number (PPN) and additional data.");
            _info.Add(BarcodeSymbologySubsets.PPN, text.ToString());


            // Code 16K
            text.Length = 0;
            text.Append("Code 16K is a stacked linear, variable length symbology capable of encoding up to 144 numeric or 77 alphabetic characters.");
            text.Append(NewLine);
            text.Append("Encodable character set: full 128-character ASCII character set.");
            text.Append(NewLine);
            text.Append(NewLine);
            text.Append(" - Special symbols: ");
            text.Append(NewLine);
            text.Append(" 1. <SA_n_m> - Structured Append character (n - symbol position, m - symbol count). See StructureAppendCharacter class.");
            text.Append(NewLine);
            text.Append(" 2. <FNC1> - FNC1 flag");
            text.Append(NewLine);
            text.Append(" 3. <FNC2> - FNC2 flag");
            text.Append(NewLine);
            text.Append(" 4. <FNC3> - FNC3 flag");
            text.Append(NewLine);
            text.Append(" 5. <FNC4> - FNC4 flag");
            text.Append(NewLine);
            text.Append(" 6. <PAD> - PAD character");
            _info.Add(BarcodeType.Code16K, text.ToString());

            // Han Xin Code
            text.Length = 0;
            text.Append("Han Xin Code is a two-dimensional barcode symbology.");
            text.Append(NewLine);
            text.Append(" - Seven data encoding modes:");
            text.Append(NewLine);
            text.Append(" 1. ASCII characters (up to 4350 characters)");
            text.Append(NewLine);
            text.Append(" 2. Byte (up to 3261 bytes)");
            text.Append(NewLine);
            text.Append(" 3. Numeric (up to 7827 digits)");
            text.Append(NewLine);
            text.Append(" 4. Common Chinese Characters in Region one data (2174 characters)");
            text.Append(NewLine);
            text.Append(" 5. Common Chinese Characters in Region two data (2174 characters)");
            text.Append(NewLine);
            text.Append(" 6. 2-byte Chinese characters data (1739 characters)");
            text.Append(NewLine);
            text.Append(" 7. 4-byte Chinese characters data (1044 characters)");
            text.Append(NewLine);
            text.Append(NewLine);
            text.Append(" - Reed-Solomon error detection and correction(4 levels)");
            text.Append(NewLine);
            text.Append(NewLine);
            text.Append(" - Special symbols: ");
            text.Append(NewLine);
            text.Append(" 1. <ECInnnnnn> - ECI character (n=0..9)");
            text.Append(NewLine);
            _info.Add(BarcodeType.HanXinCode, text.ToString());

        }

        #endregion



        #region Methods

        public static string GetInformation(BarcodeType barcodeType)
        {
            if (_info.ContainsKey(barcodeType))
                return (string)_info[barcodeType];
            return "";
        }

        public static string GetInformation(BarcodeSymbologySubset barcodeSubset)
        {
            if (_info.ContainsKey(barcodeSubset))
                return (string)_info[barcodeSubset];
            return "";
        }

        #endregion

    }
}
