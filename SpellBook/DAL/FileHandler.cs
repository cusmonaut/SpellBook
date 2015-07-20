using CsvHelper;
using MysticReference.Domain;
using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization.Formatters.Binary;

namespace MysticReference.DAL
{
    public class FileHandler
    {
        public const string masterSpellFile = "spell_full.csv";
        private static FileHandler _instance;

        private FileHandler()
        {
        }

        public void updateSpellList()
        {
            if (File.Exists(masterSpellFile))
            {
                var creationTime = File.GetCreationTimeUtc(masterSpellFile);

                if ((creationTime - DateTime.UtcNow) > new TimeSpan(7, 0, 0, 0))
                {
                    downloadCsv();
                }
            }
            else
            {
                downloadCsv();
            }
        }

        private void downloadCsv()
        {
            const string backUpFile = "masterSpellBackup.csv";
            File.Delete(backUpFile);
            if (File.Exists(masterSpellFile))
            {
                File.Copy(masterSpellFile, backUpFile);
            }

            WebClient Client = new WebClient();
            try
            {
                Client.DownloadFile("https://spreadsheets.google.com/pub?key=0AhwDI9kFz9SddG5GNlY5bGNoS2VKVC11YXhMLTlDLUE&output=csv", masterSpellFile);
            }
            catch
            {
                File.Delete(masterSpellFile);
                if (File.Exists(backUpFile))
                {
                    File.Copy(backUpFile, masterSpellFile);
                }
            }
        }

        public static FileHandler Instance
        {
            get { return _instance ?? (_instance = new FileHandler()); }
        }

        private const string FileExtention = ".sb";

        public void WriteBinaryFile(string fileName, SpellBook spellbook)
        {
            using (var stream = File.OpenWrite(fileName + FileExtention))
            {
                new BinaryFormatter().Serialize(stream, spellbook);
            }
        }

        public void ReadBinaryFile(string spellBookName, ref SpellBook spellBook)
        {
            if (spellBook == null) throw new ArgumentNullException("spellBook");
            using (var stream = File.OpenRead(spellBookName))
            {
                var newObj = (SpellBook)new BinaryFormatter().Deserialize(stream);

                spellBook = newObj;
            }
        }

        public void ReadFromCsvFile(ref SpellBook spellBook, string spellBookName = masterSpellFile)
        {
            var csvReader = new CsvReader(new StreamReader(spellBookName));

            var records = csvReader.GetRecords<Spell>();

            foreach (var record in records.OrderBy(x => x.name))
            {
                spellBook.spells.Add(record);
            }
        }
    }
}