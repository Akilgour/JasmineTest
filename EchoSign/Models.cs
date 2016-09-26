using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EchoSign
{
    public class Models
    {
        [Obsolete] // Used this to test as a big string of json
        public string GetAgreementCreationInfo()
        {
            var sb = new StringBuilder();
            sb.Append("{");
            sb.Append("\"documentCreationInfo\": {");
            sb.Append("\"signatureType\": \"ESIGN\",");
            sb.Append("\"securityOptions\": {");
            sb.Append("\"passwordProtection\": \"\",");
            sb.Append("\"kbaProtection\": \"\",");
            sb.Append("\"webIdentityProtection\": \"\",");
            sb.Append("\"protectOpen\": false,");
            sb.Append("\"internalPassword\": \"\",");
            sb.Append("\"externalPassword\": \"\",");
            sb.Append("\"openPassword\": \"\"");
            sb.Append("},");
            sb.Append("\"callbackInfo\": \"\",");
            sb.Append("\"daysUntilSigningDeadline\": 0,");
            sb.Append("\"locale\": \"\",");
            sb.Append("\"recipientSetInfos\": [");
            sb.Append("{");
            sb.Append("\"recipientSetMemberInfos\": [");
            sb.Append("{");
            sb.Append("\"securityOptions\": [");
            sb.Append("{");
            sb.Append("\"authenticationMethod\": \"\",");
            sb.Append("\"phoneInfos\": [");
            sb.Append("{");
            sb.Append("\"phone\": \"\",");
            sb.Append("\"countryCode\": \"\"");
            sb.Append("}");
            sb.Append("],");
            sb.Append("\"password\": \"\"");
            sb.Append("}");
            sb.Append("],");
            sb.Append("\"fax\": \"\",");
            sb.Append("\"email\": \"kilgourkilgour@hotmail.com\"");
            sb.Append("}");
            sb.Append("],");
            sb.Append("\"securityOptions\": [");
            sb.Append("{");
            sb.Append("\"authenticationMethod\": \"\",");
            sb.Append("\"phoneInfos\": [");
            sb.Append("{");
            sb.Append("\"phone\": \"\",");
            sb.Append("\"countryCode\": \"\"");
            sb.Append("}");
            sb.Append("],");
            sb.Append("\"password\": \"\"");
            sb.Append("}");
            sb.Append("],");
            sb.Append("\"recipientSetRole\": \"SIGNER\"");
            sb.Append("},");
            sb.Append("{");
            sb.Append("\"recipientSetMemberInfos\": [");
            sb.Append("{");
            sb.Append("\"securityOptions\": [");
            sb.Append("{");
            sb.Append("\"authenticationMethod\": \"\",");
            sb.Append("\"phoneInfos\": [");
            sb.Append("{");
            sb.Append("\"phone\": \"\",");
            sb.Append("\"countryCode\": \"\"");
            sb.Append("}");
            sb.Append("],");
            sb.Append("\"password\": \"\"");
            sb.Append("}");
            sb.Append("],");
            sb.Append("\"fax\": \"\",");
            sb.Append("\"email\": \"aksignable@gmail.com\"");
            sb.Append("}");
            sb.Append("],");
            sb.Append("\"securityOptions\": [");
            sb.Append("{");
            sb.Append("\"authenticationMethod\": \"\",");
            sb.Append("\"phoneInfos\": [");
            sb.Append("{");
            sb.Append("\"phone\": \"\",");
            sb.Append("\"countryCode\": \"\"");
            sb.Append("}");
            sb.Append("],");
            sb.Append("\"password\": \"\"");
            sb.Append("}");
            sb.Append("],");
            sb.Append("\"recipientSetRole\": \"SIGNER\"");
            sb.Append("}");
            sb.Append("],");
            sb.Append("\"signatureFlow\": \"PARALLEL\",");
            sb.Append("\"message\": \"dddd\",");
            sb.Append("\"mergeFieldInfo\": [");
            sb.Append("{");
            sb.Append("\"fieldName\": \"\",");
            sb.Append("\"defaultValue\": \"\"");
            sb.Append("}");
            sb.Append("],");
            sb.Append("\"fileInfos\": [");
            sb.Append("{");
            sb.Append("\"libraryDocumentId\": \"************************************************************8\",");
            sb.Append("\"libraryDocumentName\": \"a4\",");
            sb.Append("\"documentURL\": {");
            sb.Append("\"name\": \"\",");
            sb.Append("\"url\": \"\",");
            sb.Append("\"mimeType\": \"\"");
            sb.Append("}");
            sb.Append("    }");
            sb.Append("],");
            sb.Append("\"reminderFrequency\": \"\",");
            sb.Append("\"name\": \"DDD\"");
            sb.Append("},");
            sb.Append("\"options\": {");
            sb.Append("\"noChrome\": false,");
            sb.Append("\"sendThroughWebOptions\": {");
            sb.Append("\"fileUploadOptions\": {");
            sb.Append("\"webConnectors\": false,");
            sb.Append("\"libraryDocument\": false,");
            sb.Append("\"localFile\": false");
            sb.Append("}");
            sb.Append("},");
            sb.Append("\"sendThroughWeb\": false,");
            sb.Append("\"locale\": \"\",");
            sb.Append("\"authoringRequested\": false,");
            sb.Append("\"autoLoginUser\": false");
            sb.Append("}");
            sb.Append("}");

            return sb.ToString();

        }

        public Rootobject GetAgreementCreationObject()
        {
            var rootobject = new Rootobject();

            var documentCreationInfo = new Documentcreationinfo();
            documentCreationInfo.signatureType = "ESIGN";

            var securityOptions = new Securityoptions();
            securityOptions.passwordProtection = "";
            securityOptions.kbaProtection = "";
            securityOptions.webIdentityProtection = "";
            securityOptions.protectOpen = false;
            securityOptions.internalPassword = "";
            securityOptions.externalPassword = "";
            securityOptions.openPassword = "";

            documentCreationInfo.securityOptions = securityOptions;
            documentCreationInfo.callbackInfo = "";
            documentCreationInfo.daysUntilSigningDeadline = 0;
            documentCreationInfo.locale = "";

            documentCreationInfo.recipientSetInfos = new Recipientsetinfo[1];
           // documentCreationInfo.recipientSetInfos = GetrecipientSetInfos(); //AK SEND TWO AT SAME TIME
            documentCreationInfo.recipientSetInfos = GetrecipientSetInfosTwo();


            documentCreationInfo.signatureFlow = "SENDER_SIGNS_LAST"; // Or have PARALLEL to both get at same time
            documentCreationInfo.message = " This is the msg we give people when the drop of cars there be word here that will say stuff, probably some big words, i can also customsise it so everyone gets something specail.";
            documentCreationInfo.mergeFieldInfo = new Mergefieldinfo[1];
            documentCreationInfo.mergeFieldInfo[0] = new Mergefieldinfo();
            documentCreationInfo.mergeFieldInfo[0].fieldName = "";
            documentCreationInfo.mergeFieldInfo[0].defaultValue = "";

            documentCreationInfo.fileInfos = new Fileinfo[1];
            documentCreationInfo.fileInfos[0] = new Fileinfo();
            documentCreationInfo.fileInfos[0].libraryDocumentId = " ************************************************************8";
            documentCreationInfo.fileInfos[0].libraryDocumentName = "a4"; //AK Yeah this is the document name, not good but was testing
            documentCreationInfo.fileInfos[0].documentURL = new Documenturl() { name = "", url = "", mimeType = "" };

            documentCreationInfo.reminderFrequency = "";
            documentCreationInfo.name = " Car drop of document, I can change this when we send the document so all are snow flakes.";

            var options = new Options();
            options.noChrome = false;
            options.sendThroughWebOptions = new Sendthroughweboptions();
            options.sendThroughWebOptions.fileUploadOptions = new Fileuploadoptions();
            options.sendThroughWebOptions.fileUploadOptions.webConnectors = false;
            options.sendThroughWebOptions.fileUploadOptions.libraryDocument = false;
            options.sendThroughWebOptions.fileUploadOptions.localFile = false;

            options.sendThroughWeb = false;
            options.locale = "";
            options.authoringRequested = false;
            options.autoLoginUser = false;

            rootobject.documentCreationInfo = documentCreationInfo;
            rootobject.options = options;

            return rootobject;
        }


        private Recipientsetinfo[] GetrecipientSetInfos()
        {

            var recipientsetinfo = new Recipientsetinfo[1];
            recipientsetinfo[0] = new Recipientsetinfo();
            recipientsetinfo[0].recipientSetMemberInfos = new Recipientsetmemberinfo[2];
            recipientsetinfo[0].recipientSetMemberInfos[0] = new Recipientsetmemberinfo();
            recipientsetinfo[0].recipientSetMemberInfos[0].securityOptions = new Securityoption[1];
            recipientsetinfo[0].recipientSetMemberInfos[0].securityOptions[0] = new Securityoption();
            recipientsetinfo[0].recipientSetMemberInfos[0].securityOptions[0].authenticationMethod = "";
            recipientsetinfo[0].recipientSetMemberInfos[0].securityOptions[0].phoneInfos = new Phoneinfo[1];
            recipientsetinfo[0].recipientSetMemberInfos[0].securityOptions[0].phoneInfos[0] = new Phoneinfo();
            recipientsetinfo[0].recipientSetMemberInfos[0].securityOptions[0].phoneInfos[0].phone = "";
            recipientsetinfo[0].recipientSetMemberInfos[0].securityOptions[0].phoneInfos[0].countryCode = "";
            recipientsetinfo[0].recipientSetMemberInfos[0].securityOptions[0].password = "";
            recipientsetinfo[0].recipientSetMemberInfos[0].fax = "";
            recipientsetinfo[0].recipientSetMemberInfos[0].email = "kilgourkilgour@hotmail.com";

            recipientsetinfo[0].securityOptions = new Securityoption1[1];
            recipientsetinfo[0].securityOptions[0] = new Securityoption1();
            recipientsetinfo[0].securityOptions[0].authenticationMethod = "";
            recipientsetinfo[0].securityOptions[0].phoneInfos = new Phoneinfo1[1];
            recipientsetinfo[0].securityOptions[0].phoneInfos[0] = new Phoneinfo1();
            recipientsetinfo[0].securityOptions[0].phoneInfos[0].phone = "";
            recipientsetinfo[0].securityOptions[0].phoneInfos[0].countryCode = "";
            recipientsetinfo[0].securityOptions[0].password = "";
            recipientsetinfo[0].recipientSetRole = "SIGNER";

            recipientsetinfo[0].recipientSetMemberInfos[1] = new Recipientsetmemberinfo();
            recipientsetinfo[0].recipientSetMemberInfos[1].securityOptions = new Securityoption[1];
            recipientsetinfo[0].recipientSetMemberInfos[1].securityOptions[0] = new Securityoption();
            recipientsetinfo[0].recipientSetMemberInfos[1].securityOptions[0].authenticationMethod = "";
            recipientsetinfo[0].recipientSetMemberInfos[1].securityOptions[0].phoneInfos = new Phoneinfo[1];
            recipientsetinfo[0].recipientSetMemberInfos[1].securityOptions[0].phoneInfos[0] = new Phoneinfo();
            recipientsetinfo[0].recipientSetMemberInfos[1].securityOptions[0].phoneInfos[0].phone = "";
            recipientsetinfo[0].recipientSetMemberInfos[1].securityOptions[0].phoneInfos[0].countryCode = "";
            recipientsetinfo[0].recipientSetMemberInfos[1].securityOptions[0].password = "";
            recipientsetinfo[0].recipientSetMemberInfos[1].fax = "";
            recipientsetinfo[0].recipientSetMemberInfos[1].email = "aksignable@gmail.com";

            return recipientsetinfo;
        }

        private Recipientsetinfo[] GetrecipientSetInfosTwo()
        {

            var recipientsetinfo = new Recipientsetinfo[2];
            recipientsetinfo[0] = new Recipientsetinfo();

            recipientsetinfo[0].recipientSetMemberInfos = new Recipientsetmemberinfo[1];
            recipientsetinfo[0].recipientSetMemberInfos[0] = new Recipientsetmemberinfo();
            recipientsetinfo[0].recipientSetMemberInfos[0].securityOptions = new Securityoption[1];
            recipientsetinfo[0].recipientSetMemberInfos[0].securityOptions[0] = new Securityoption();
            recipientsetinfo[0].recipientSetMemberInfos[0].securityOptions[0].authenticationMethod = "";
            recipientsetinfo[0].recipientSetMemberInfos[0].securityOptions[0].phoneInfos = new Phoneinfo[1];
            recipientsetinfo[0].recipientSetMemberInfos[0].securityOptions[0].phoneInfos[0] = new Phoneinfo();
            recipientsetinfo[0].recipientSetMemberInfos[0].securityOptions[0].phoneInfos[0].phone = "";
            recipientsetinfo[0].recipientSetMemberInfos[0].securityOptions[0].phoneInfos[0].countryCode = "";
            recipientsetinfo[0].recipientSetMemberInfos[0].securityOptions[0].password = "";
            recipientsetinfo[0].recipientSetMemberInfos[0].fax = "";
            recipientsetinfo[0].recipientSetMemberInfos[0].email = "kilgourkilgour@hotmail.com";

            recipientsetinfo[0].securityOptions = new Securityoption1[1];
            recipientsetinfo[0].securityOptions[0] = new Securityoption1();
            recipientsetinfo[0].securityOptions[0].authenticationMethod = "";
            recipientsetinfo[0].securityOptions[0].phoneInfos = new Phoneinfo1[1];
            recipientsetinfo[0].securityOptions[0].phoneInfos[0] = new Phoneinfo1();
            recipientsetinfo[0].securityOptions[0].phoneInfos[0].phone = "";
            recipientsetinfo[0].securityOptions[0].phoneInfos[0].countryCode = "";
            recipientsetinfo[0].securityOptions[0].password = "";
            recipientsetinfo[0].recipientSetRole = "SIGNER";

            recipientsetinfo[1] = new Recipientsetinfo();
            recipientsetinfo[1].recipientSetMemberInfos = new Recipientsetmemberinfo[1];
            recipientsetinfo[1].recipientSetMemberInfos[0] = new Recipientsetmemberinfo();
            recipientsetinfo[1].recipientSetMemberInfos[0].securityOptions = new Securityoption[1];
            recipientsetinfo[1].recipientSetMemberInfos[0].securityOptions[0] = new Securityoption();
            recipientsetinfo[1].recipientSetMemberInfos[0].securityOptions[0].authenticationMethod = "";
            recipientsetinfo[1].recipientSetMemberInfos[0].securityOptions[0].phoneInfos = new Phoneinfo[1];
            recipientsetinfo[1].recipientSetMemberInfos[0].securityOptions[0].phoneInfos[0] = new Phoneinfo();
            recipientsetinfo[1].recipientSetMemberInfos[0].securityOptions[0].phoneInfos[0].phone = "";
            recipientsetinfo[1].recipientSetMemberInfos[0].securityOptions[0].phoneInfos[0].countryCode = "";
            recipientsetinfo[1].recipientSetMemberInfos[0].securityOptions[0].password = "";
            recipientsetinfo[1].recipientSetMemberInfos[0].fax = "";
            recipientsetinfo[1].recipientSetMemberInfos[0].email = "aksignable@gmail.com";
                             
            recipientsetinfo[1].securityOptions = new Securityoption1[1];
            recipientsetinfo[1].securityOptions[0] = new Securityoption1();
            recipientsetinfo[1].securityOptions[0].authenticationMethod = "";
            recipientsetinfo[1].securityOptions[0].phoneInfos = new Phoneinfo1[1];
            recipientsetinfo[1].securityOptions[0].phoneInfos[0] = new Phoneinfo1();
            recipientsetinfo[1].securityOptions[0].phoneInfos[0].phone = "";
            recipientsetinfo[1].securityOptions[0].phoneInfos[0].countryCode = "";
            recipientsetinfo[1].securityOptions[0].password = "";
            recipientsetinfo[1].recipientSetRole = "APPROVER";

            return recipientsetinfo;
        }

        public class Rootobject
        {
            public Documentcreationinfo documentCreationInfo { get; set; }
            public Options options { get; set; }
        }

        public class Documentcreationinfo
        {
            public string signatureType { get; set; }
            public Securityoptions securityOptions { get; set; }
            public string callbackInfo { get; set; }
            public int daysUntilSigningDeadline { get; set; }
            public string locale { get; set; }
            public Recipientsetinfo[] recipientSetInfos { get; set; }
            public string signatureFlow { get; set; }
            public string message { get; set; }
            public Mergefieldinfo[] mergeFieldInfo { get; set; }
            public Fileinfo[] fileInfos { get; set; }
            public string reminderFrequency { get; set; }
            public string name { get; set; }
        }

        public class Securityoptions
        {
            public string passwordProtection { get; set; }
            public string kbaProtection { get; set; }
            public string webIdentityProtection { get; set; }
            public bool protectOpen { get; set; }
            public string internalPassword { get; set; }
            public string externalPassword { get; set; }
            public string openPassword { get; set; }
        }

        public class Recipientsetinfo
        {
            public Recipientsetmemberinfo[] recipientSetMemberInfos { get; set; }
            public Securityoption1[] securityOptions { get; set; }
            public string recipientSetRole { get; set; }
        }

        public class Recipientsetmemberinfo
        {
            public Securityoption[] securityOptions { get; set; }
            public string fax { get; set; }
            public string email { get; set; }
        }

        public class Securityoption
        {
            public string authenticationMethod { get; set; }
            public Phoneinfo[] phoneInfos { get; set; }
            public string password { get; set; }
        }

        public class Phoneinfo
        {
            public string phone { get; set; }
            public string countryCode { get; set; }
        }

        public class Securityoption1
        {
            public string authenticationMethod { get; set; }
            public Phoneinfo1[] phoneInfos { get; set; }
            public string password { get; set; }
        }

        public class Phoneinfo1
        {
            public string phone { get; set; }
            public string countryCode { get; set; }
        }

        public class Mergefieldinfo
        {
            public string fieldName { get; set; }
            public string defaultValue { get; set; }
        }

        public class Fileinfo
        {
            public string libraryDocumentId { get; set; }
            public string libraryDocumentName { get; set; }
            public Documenturl documentURL { get; set; }
        }

        public class Documenturl
        {
            public string name { get; set; }
            public string url { get; set; }
            public string mimeType { get; set; }
        }

        public class Options
        {
            public bool noChrome { get; set; }
            public Sendthroughweboptions sendThroughWebOptions { get; set; }
            public bool sendThroughWeb { get; set; }
            public string locale { get; set; }
            public bool authoringRequested { get; set; }
            public bool autoLoginUser { get; set; }
        }

        public class Sendthroughweboptions
        {
            public Fileuploadoptions fileUploadOptions { get; set; }
        }

        public class Fileuploadoptions
        {
            public bool webConnectors { get; set; }
            public bool libraryDocument { get; set; }
            public bool localFile { get; set; }
        }

    }
}