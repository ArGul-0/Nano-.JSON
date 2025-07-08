namespace Nano_.JSON
{
    using Newtonsoft.Json;

    public class Storage
    {
        private readonly string JSONFilePathRecentFiles;

        public Storage()
        {
            // 1. Путь к %APPDATA%
            string appData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            // 2. Более корректное имя папки без пробелов и точек на конце
            string myFolder = Path.Combine(appData, "Nano .JSON");
            // 3. Создаём папку, если её нет
            Directory.CreateDirectory(myFolder);
            // 4. Полный путь к файлу RecentFiles.json
            JSONFilePathRecentFiles = Path.Combine(myFolder, "RecentFiles.json");

            if (File.Exists(JSONFilePathRecentFiles) == false)
            {
                File.WriteAllText(JSONFilePathRecentFiles, "");
            }
        }
        public void SaveRecentFile(List<string> recentFile)
        {
            try
            {
                string jsonContent = JsonConvert.SerializeObject(recentFile);
                File.WriteAllText(JSONFilePathRecentFiles, jsonContent);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving the .JSON file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public List<string> LoadRecentFiles()
        {
            List<string> lastFiles = new List<string>();
            try
            {
                if (File.Exists(JSONFilePathRecentFiles))
                {
                    string jsonContent = File.ReadAllText(JSONFilePathRecentFiles);
                    lastFiles = JsonConvert.DeserializeObject<List<string>>(jsonContent) ?? new List<string>();
                    return lastFiles;
                }
                MessageBox.Show($".JSON file does not exist:", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading the .JSON file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
    }
}
