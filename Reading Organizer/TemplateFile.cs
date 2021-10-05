using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Reading_Organizer
{
    class TemplateFile
    {
        public static void SaveTemplate(string path, Hashtable data) {
            try {
                string json = JsonSerializer.Serialize(data);
                File.WriteAllText(path, json);
            } catch (Exception e) {
                // TODO: create and launch custom exception
            }
        }

        public static Hashtable LoadTemplate(string path) {
            Hashtable result = null;
            try {
                if (File.Exists(path)) {
                    string json = File.ReadAllText(path);
                    result = JsonSerializer.Deserialize<Hashtable>(json);
                }
            } catch (Exception e) {
                // TODO: create and launch custom exception
            }
            return result;
        }

    }
}
