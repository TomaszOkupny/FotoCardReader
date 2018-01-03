using Microsoft.Win32;

namespace FotoCardReader
{
    public static class Reg
    {
        private static string ProgramKey = "HKEY_CURRENT_USER\\FotoCardReader";

        public static string LastDirectory{
            get {
                return getKeyValue("LastDirectory");
            }
            set {
                setKey("LastDirectory", value);
            }

        }




        private static void setKey(string key, string value)
        {
            Registry.SetValue(ProgramKey, key, value,  RegistryValueKind.ExpandString);
        }

        private static string getKeyValue(string key)
        {
            string keyValue = (string)Registry.GetValue(ProgramKey, key,string.Empty);
            return keyValue;
        }

    }
}
