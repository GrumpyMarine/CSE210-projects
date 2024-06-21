public class Journal
    {
        public List<Entry> _entries= new List<Entry>();
        public void AddEntry(Entry newEntry)
        {
            _entries.Add(newEntry);
        }

        public void DisplayAll()
        {
            foreach (Entry entry in _entries)
            {
                entry.Display();
            }
        }

        public void SaveToFile(string filename)
        {
            using(StreamWriter file = new StreamWriter(filename))
            {
                foreach(Entry entry in _entries)
                {
                    file.WriteLine($"{entry._date}|{entry._promptText}|{entry._entryText}");
                }
            }
        }

        public void LoadFromFile(string filename)
        {
            _entries.Clear();
            using(StreamReader file = new StreamReader(filename))
            {
                string line;
                while ((line = file.ReadLine()) != null)
                {
                    string[] parts = line.Split('|');
                    if (parts.Length == 3)
                    {
                        _entries.Add(new Entry(parts[1], parts[2], parts[0]));
                    }
                }
            }
        }

    }