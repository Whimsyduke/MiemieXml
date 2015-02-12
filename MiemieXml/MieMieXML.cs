using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Xml;
using System.Xml.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.Xml;

namespace MiemieXml
{
    public partial class MieMieXML : Form
    {
        TreeNode rootNode = new TreeNode("\\");

        public MieMieXML()
        {
            InitializeComponent();
            DirectoryInfo startFolder = new DirectoryInfo(Application.StartupPath);
            GetChildFolder(ref rootNode, startFolder);
            this.treeViewALL.Nodes.Add(rootNode);
        }

        //生成子路径结点
        public void GetChildFolder(ref TreeNode parentTreeNode, DirectoryInfo parentFolder)
        {
            string rootPath = Application.StartupPath;
            DirectoryInfo[] parentFolders = parentFolder.GetDirectories();
            foreach (DirectoryInfo folder in parentFolders)
            {
                TreeNode childTreeNode = new TreeNode(folder.Name);
                parentTreeNode.Nodes.Add(childTreeNode);
                GetChildFolder(ref childTreeNode, folder);
            }
        }

        //勾选结点
        private void treeViewALL_AfterCheck(object sender, TreeViewEventArgs e)
        {
            CheckChildNode(e.Node, e.Node.Checked);
        }

        //勾选子结点
        public void CheckChildNode(TreeNode parentTreeNode, bool checkType)
        {
            foreach (TreeNode childTreeNode in parentTreeNode.Nodes)
            {
                childTreeNode.Checked = checkType;
                CheckChildNode(childTreeNode, checkType);
            }
        }

        //检测添加目录
        private void buttonAddCheck_Click(object sender, EventArgs e)
        {
            if (rootNode.Checked)
            {
                if (!this.checkedListBoxFullCheck.Items.Contains("\\")) this.checkedListBoxFullCheck.Items.Add("\\");
            }
            AddFolder(rootNode, new DirectoryInfo(Application.StartupPath), true, false);
            rootNode.Checked = false;
        }

        //检测添加删除
        private void buttonDelCheck_Click(object sender, EventArgs e)
        {
            List<string> paths = new List<string>();
            foreach (var path in this.checkedListBoxFullCheck.CheckedItems) paths.Add(path.ToString());
            foreach (var path in paths) this.checkedListBoxFullCheck.Items.Remove(path);
        }

        //更新添加目录
        private void buttonAddUpdata_Click(object sender, EventArgs e)
        {
            if (rootNode.Checked)
            {
                if (!this.checkedListBoxFolder.Items.Contains("\\")) this.checkedListBoxFolder.Items.Add("\\");
            }
            AddFolder(rootNode, new DirectoryInfo(Application.StartupPath), false, true);
            rootNode.Checked = false;
        }

        //更新删除选择的目录
        private void buttonDelUpdata_Click(object sender, EventArgs e)
        {
            List<string> paths = new List<string>();
            foreach (var path in this.checkedListBoxFolder.CheckedItems) paths.Add (path.ToString());
            foreach (var path in paths) this.checkedListBoxFolder.Items.Remove(path);
        }

        //添加二者目录
        private void buttonAddAll_Click(object sender, EventArgs e)
        {
            if (rootNode.Checked)
            {
                if (!this.checkedListBoxFullCheck.Items.Contains("\\")) this.checkedListBoxFullCheck.Items.Add("\\");
                if (!this.checkedListBoxFolder.Items.Contains("\\")) this.checkedListBoxFolder.Items.Add("\\");
            }
            AddFolder(rootNode, new DirectoryInfo(Application.StartupPath), true, true);
            rootNode.Checked = false;
        }

        //遍历子目录
        public void AddFolder(TreeNode parentTreeNode, DirectoryInfo parentFolder, bool check, bool updata)
        {
            string rootPath = Application.StartupPath;
            string path = parentFolder.FullName;
            foreach (TreeNode childTreeNode in parentTreeNode.Nodes)
            {
                DirectoryInfo dir = new DirectoryInfo(path + "\\" + childTreeNode.Text);
                AddFolder(childTreeNode, dir, check, updata);
                if (childTreeNode.Checked)
                {
                    string folderPath = dir.FullName.Replace(rootPath, "");
                    childTreeNode.Checked = false;
                    if (check && !this.checkedListBoxFullCheck.Items.Contains(folderPath)) this.checkedListBoxFullCheck.Items.Add(folderPath);
                    if (updata && !this.checkedListBoxFolder.Items.Contains(folderPath)) this.checkedListBoxFolder.Items.Add(folderPath);
                }
            }
        }

        //生成XML
        private void buttonXML_Click(object sender, EventArgs e)
        {
            DirectoryInfo folder = new DirectoryInfo(Application.StartupPath);
            XElement rootXEL = new XElement("Root");
            if (File.Exists(folder.FullName + "\\Updata.xml")) File.Delete(folder.FullName + "\\Updata.xml");

            XElement simpleXEL = new XElement("Folder",
                new XAttribute("Size", 0),
                new XAttribute("Synchronous", this.checkedListBoxFolder.Items.Contains("\\")),
                new XAttribute("FtpPath", "/"),
                new XAttribute("PCPath", "\\"));
            XElement tempXEL = new XElement("SimpleUpdata");
            tempXEL.Add(simpleXEL);
            rootXEL.Add(tempXEL);

            XElement fullXEL = new XElement("Folder",
                new XAttribute("Size", 0),
                new XAttribute("Synchronous", this.checkedListBoxFullCheck.Items.Contains("\\")),
                new XAttribute("FtpPath", "/"),
                new XAttribute("PCPath", "\\"));
            tempXEL = new XElement("FullCheck");
            tempXEL.Add(fullXEL);
            rootXEL.Add(tempXEL);

            if (this.checkedListBoxFolder.Items.Contains("\\")) CreateXML(simpleXEL, new DirectoryInfo(Application.StartupPath), false);
            foreach (string path in this.checkedListBoxFolder.Items)
            {
                XElement childXEL;
                tempXEL = simpleXEL;
                string pathXEL = "";
                foreach (string folderName in path.Split(new string[] { "\\" }, System.StringSplitOptions.RemoveEmptyEntries))
                {
                    pathXEL += "\\" + folderName;
                    childXEL = null;
                    foreach (XElement XEL in tempXEL.Elements("Folder"))
                    {
                        if (XEL.Attribute("PCPath").Value == pathXEL)
                        {
                            childXEL = XEL;
                            break;
                        }
                    }
                    if (childXEL == null)
                    {
                        childXEL = new XElement("Folder",
                            new XAttribute("Size", 0),
                            new XAttribute("Synchronous", false),
                            new XAttribute("FtpPath", pathXEL.Replace("\\", "/")),
                            new XAttribute("PCPath", pathXEL));
                        tempXEL.Add(childXEL);
                    }
                    tempXEL = childXEL;
                }
                tempXEL.Attribute("Synchronous").Value = this.checkedListBoxFullCheck.Items.Contains(pathXEL).ToString();
                CreateXML(tempXEL, new DirectoryInfo(Application.StartupPath + path), false);
            }
            CreateXML(fullXEL, folder, true);
            rootXEL.Save(folder.FullName + "\\Updata.xml", SaveOptions.None);
            MessageBox.Show("Updata.xml文件生成完成.", "生成完成", MessageBoxButtons.OK);
        }

        //递归XML路径
        public void CreateXML(XElement parentXEL, DirectoryInfo parentFolder, bool Recursion)
        {
            string rootPath = Application.StartupPath;
            foreach (FileInfo file in parentFolder.GetFiles())
            {
                string path = file.FullName.Replace(rootPath, "");
                if (path.ToLower() == Application.ExecutablePath.Replace(rootPath, "").ToLower()) continue;
                parentXEL.Add(new XElement("File",
                    new XAttribute("Size", file.Length),
                    new XAttribute("FtpPath", path.Replace("\\", "/")),
                    new XAttribute("PCPath", path)));
            } 
            foreach (DirectoryInfo folder in parentFolder.GetDirectories())
            {
                string path = folder.FullName.Replace(rootPath, "");
                bool checkFolder = this.checkedListBoxFolder.Items.Contains(path);
                XElement childXEL = new XElement("Folder",
                    new XAttribute("Size", 0),
                    new XAttribute("Synchronous", this.checkedListBoxFullCheck.Items.Contains(path)),
                    new XAttribute("FtpPath", path.Replace("\\", "/")),
                    new XAttribute("PCPath", path));
                parentXEL.Add(childXEL);
                if (Recursion) CreateXML(childXEL, folder, Recursion);
            }
        }

        //加密信息
        static byte[] EncryptStringToBytes_Aes(string plainText, byte[] Key, byte[] IV)
        {
            // Check arguments.
            if (plainText == null || plainText.Length <= 0)
                throw new ArgumentNullException("plainText");
            if (Key == null || Key.Length <= 0)
                throw new ArgumentNullException("Key");
            if (IV == null || IV.Length <= 0)
                throw new ArgumentNullException("Key");

            byte[] encrypted;
            // Create an Aes object
            // with the specified key and IV.
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = Key;
                aesAlg.IV = IV;

                // Create a decrytor to perform the stream transform.
                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

                // Create the streams used for encryption.
                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {

                            //Write all data to the stream.
                            swEncrypt.Write(plainText);
                        }
                        encrypted = msEncrypt.ToArray();
                    }
                }
            }

            // Return the encrypted bytes from the memory stream.
            return encrypted;

        }
        static string DecryptStringFromBytes_Aes(byte[] cipherText, byte[] Key, byte[] IV)
        {
            // Check arguments.
            if (cipherText == null || cipherText.Length <= 0)
                throw new ArgumentNullException("cipherText");
            if (Key == null || Key.Length <= 0)
                throw new ArgumentNullException("Key");
            if (IV == null || IV.Length <= 0)
                throw new ArgumentNullException("Key");

            // Declare the string used to hold
            // the decrypted text.
            string plaintext = null;

            // Create an Aes object
            // with the specified key and IV.
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = Key;
                aesAlg.IV = IV;

                // Create a decrytor to perform the stream transform.
                ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

                // Create the streams used for decryption.
                using (MemoryStream msDecrypt = new MemoryStream(cipherText))
                {
                    using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                        {

                            // Read the decrypted bytes from the decrypting stream
                            // and place them in a string.
                            plaintext = srDecrypt.ReadToEnd();
                        }
                    }
                }

            }
            return plaintext;
        }
        string[] keys = {"4126c36b0e581dfe373604c24827955f",
                         "2b755840b80f859ddf8caed5759aa78f",
                         "8c9ddcc5ebaec870665f55779172a5a9",
                         "b304827a877bca31a0268c81aa47899d",
                         "8e7536aa4bd0737dace7d958ba0e0b6d",
                         "e7042170182d0710d3ab24c52146c61f",
                         "d5b8e81c3cfb5de39004cd9fa2717692",
                         "1a1e9aa5261885616d25d7a0acae5b66",
                         "21ba830225ee31eca73de01360686d61",
                         "3491aa03ab20f8bd3287af1623bd37e2",
                         "a9667ee8ee746d2bedaefee838710004",
                         "b7766c1a0358ba00c1c5cf9d3f1ac8ea",
                         "06fe6af9ea8572bf247f15fd221084c1",
                         "87aa5fad511dde51ac7d2728a5cfecd3",
                         "e614e23a07061a3203acf68442bcdeb0",
                         "410d1694bb1a98e91f194d6d5d4a1a54",
                         "9241170d2d4aba80902caaa4265a0eef",
                         "9e76e797b95718cb7bf91aeeb9add5b9",
                         "91a2f100a5d182f65396048e70f4c2c5",
                         "0a5ecee662839b3a294c91342fcbc7e3",
                         "57f01384680d49cdf3f1432253895a87",
                         "3755e35adeee570e06b6d7593f4ec687",
                         "cf21377fe03d5cfc1400f2714078e7a0",
                         "f10afdd9e86c046999057db136f08ea5",
                         "2abb533252daa6f9f9e646defbe5cd8e",
                         "cf37673451ec9f621dcee6dbc0aac624",
                         "724d468425b44d166304e00125266db3",
                         "37efe2ff8859543d1bf01583f4cb384e",
                         "20226bae9e48681ae951d14c0b9e3cf7",
                         "6032a3d0c8c79b18f90969349fca2298",
                         "cb92e103babf15ee86c716378807317d",
                         "b31e23c1276885588653b495df347b1f",
                         "2e388179bc383ca11db54900b1648ff1",
                         "d8ec8081a66070630c887d660a7f0f52",
                         "4cf7085085b8c07ae182a4721e84a721",
                         "c3c2bcf3b3f978cdc71e6c34bbd5969d",
                         "a6f7b4ba5b3f6c202b069f24bbfe4488",
                         "e15ca347c21b9f527e3a88674b8cbf0b",
                         "eb07cb27d0edc584569cc7ac5a5311c9",
                         "d9e4525f324fda8a57613b20b704d49f",
                         "469439b4321db7f3961ef02654f2f82b",
                         "28be8e673960d89c2d41cf6fb2a5cd52",
                         "c82866c61a5d96bb2c5ec8145eb43665",
                         "680ff7f8756d65e6bb9c87f14e4841f1",
                         "519e5e2b8c3211cb28d33ada97c43e79",
                         "0a6a06a2add4dc5ac27f0a7dd6a46ce4",
                         "1dd7c2c0560ad835fe2ccfa2328b4ef6",
                         "5e0ee6e4419f447cc103690c2794f583",
                         "6656bdc0027d230091d0a48005392836",
                         "31141ec8be88a27e9345fe52a1cc0d6a",
                         "374b3cdcce8ef3e1eae65270fbc37787",
                         "da32db12762cc5ddb43e2cbc7ed05ec5",
                         "c33949b9fd4c68a2213cddd7353183cf",
                         "ce77776ef0faf40a865f278f6137621a",
                         "878dadc17abe8a8ec938f1394feea783",
                         "bb5cee0758f0d4c8453e329d24d941e9",
                         "dac24fa883c25510ece9a4b809bbbb97",
                         "b7a4d304495ac297b9e57b3b8bec6af0",
                         "f7075e8c9ffffff907dd1a6f4b1cbf8a",
                         "839be57f053ca07f00b7ef9d471a84ff",
                         "7eb3c0015c2ff8b8a5dafd6b40534c9c",
                         "26f0b8f007eaebba67de8ce71062b2ec",
                         "581bf0975bbe2e54a22dda2b3f353fad",
                         "6b5276566194f894c806997da311a842",
                         "2710122463b44168c2644dda0fbf7b32",
                         "9fde7cbdeb5b8bc3225cce5424b0b091",
                         "8497032e221a49b6100e94fd471e8409",
                         "8b67dec494ea57cb854e0207e6ed4411",
                         "b3bc5578bb4c0f8494c5addcc78e7c04",
                         "d7c5c9bcd1ecfc993f37a9d31842d023",
                         "c982498ac80c4d3e585a2fcf3c7b04f7",
                         "d1fe2f20238740c6bfbc3883a33b6b51",
                         "f58a124444f23bcb788b6477bd2d5cc4",
                         "33b2011a13afff414282ca0cd3c99b1c",
                         "eeddd9b268c0b2dfc263a89823c80892",
                         "5f7350f039513e458ad101c1272ef7ae",
                         "ef4788e053aa5c72ff2257b007671e7a",
                         "7938ad6078aae29c9f942797bff0b893",
                         "6bf9a8dc40283eb516def117fa8d3d23",
                         "b28747ef8197364564eb41bf82c5b20f",
                         "6ac3440ebf423951f9f8499ab9cba211",
                         "5604e438a9c812d3c2627754e77f3251",
                         "2be2ad36492f63704df6f5894d9c8c99",
                         "4930687de17a65a1b0704b5ccae56a79",
                         "c5f86ed71e6bc727a073ebb2d3898526",
                         "d6dd0ab617b56fb07c0b85d8e307a667",
                         "8b7bc3552db47bdd6840dc6e8fb3cd27",
                         "ea2586ecdbb3621089bd5b12e5ef4499",
                         "cd832657c530f821622c4ed6d80121c8",
                         "3e5eedbd81b98cd818b3cc6f5968f778",
                         "fb42a00b8c7661ba2c648aae658c3787",
                         "9c92d48701871814f74e3e126489c8f9",
                         "34d5da9560163cc7fc33901c2edd728c",
                         "7b44d3c7947076742a8c133e374e56a3",
                         "9c907990b1a22786560c8acef6fbe51a",
                         "dbb2971fb60165c45e656bd402fe90ad",
                         "dded809e64e2dad91d4c7088e5a87e2e",
                         "a7f96284b736ed9b2bb4314c36538358",
                         "7bddf0087a47b5f9d8be016990dcdfb5",
                         "e63c2d099b0cf6a6ffe572afb08ea2ca"
};
        public static byte[] StringToByteArray(String hex)
        {
            int NumberChars = hex.Length;
            byte[] bytes = new byte[NumberChars / 2];
            for (int i = 0; i < NumberChars; i += 2)
                bytes[i / 2] = Convert.ToByte(hex.Substring(i, 2), 16);
            return bytes;
        }
        public static string ByteArrayToString(byte[] ba)
        {
            StringBuilder hex = new StringBuilder(ba.Length * 2);
            foreach (byte b in ba)
                hex.AppendFormat("{0:x2}", b);
            return hex.ToString();
        }
        private void ButtonGenerationSet_Click(object sender, EventArgs e)
        {
            //生成xml
            Random ran = new Random((int)(DateTime.Now.Ticks & 0xffffffffL) | (int) (DateTime.Now.Ticks >> 32));
            int randomKey = ran.Next(0, 99);
            int randomVI = ran.Next(0, 99);
            XElement xElData = new XElement("ServersData",
                new XAttribute("KEY", randomKey),
                new XAttribute("VI", randomVI),
                new XElement("LTIP", ByteArrayToString(EncryptStringToBytes_Aes(this.TextBoxIPLT.Text, StringToByteArray(keys[randomKey]), StringToByteArray(keys[randomVI])))),
                new XElement("DXIP", ByteArrayToString(EncryptStringToBytes_Aes(this.TextBoxIPDX.Text, StringToByteArray(keys[randomKey]), StringToByteArray(keys[randomVI])))),
                new XElement("FTPID", ByteArrayToString(EncryptStringToBytes_Aes(this.TextBoxID.Text, StringToByteArray(keys[randomKey]), StringToByteArray(keys[randomVI])))),
                new XElement("FTPPW", ByteArrayToString(EncryptStringToBytes_Aes(this.TextBoxPassword.Text, StringToByteArray(keys[randomKey]), StringToByteArray(keys[randomVI]))))
                );

            xElData.Save("ServersSetting.xml");
            MessageBox.Show("服务器设置文件已经生成，请复制ServersSetting.xml文件到更新程序所在目录！", "生成完成", MessageBoxButtons.OK);
        }
    }
}