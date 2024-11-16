using System;
// using System.Collections.Generic;
using System.IO;

public class Journal
{
    public List<Entry> Entries { get; set; }

    public Journal()
    {
        Entries = new List<Entry>();
    }

    public void AddEntry(Entry entry)
    {
        Entries.Add(entry);
    }

    public void DisplayEntries()
    {
        foreach (var entry in Entries)
        {
            Console.WriteLine($"Date: {entry.Date}");
            Console.WriteLine($"Prompt: {entry.Prompt}");
            Console.WriteLine($"Response: {entry.Response}\n");
        }
    }

    public void SaveToFile(string userJournal)
    {
        using (StreamWriter writer = new StreamWriter(userJournal))
        {
            foreach (var entry in Entries)
            {
                writer.WriteLine($"{entry.Date}|{entry.Prompt}|{entry.Response}");
            }
        }
    }

    public void LoadFromFile(string userJournal)
    {
        Entries.Clear();
        using (StreamReader reader = new StreamReader(userJournal))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                var parts = line.Split('|');
                if (parts.Length == 3)
                {
                    Entries.Add(new Entry
                    {
                        Date = parts[0],
                        Prompt = parts[1],
                        Response = parts[2]
                    });
                }
            }
        }
    }
}
