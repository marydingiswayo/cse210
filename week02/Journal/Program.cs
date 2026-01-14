using System;
using System.Collections.Generic;
using System.IO;

namespace JournalProgram
{
    // Entry class - represents a single journal entry
    public class Entry
    {
        public string _date;
        public string _promptText;
        public string _entryText;
        
        public Entry(string date, string prompt, string text)
        {
            _date = date;
            _promptText = prompt;
            _entryText = text;
        }
        
        public void Display()
        {
            Console.WriteLine($"Date: {_date}");
            Console.WriteLine($"Prompt: {_promptText}");
            Console.WriteLine($"Entry: {_entryText}");
            Console.WriteLine();
        }
        
        public string GetFormattedEntry()
        {
            return $"{_date}|{_promptText}|{_entryText}";
        }
    }
    
    // PromptGenerator class - generates random writing prompts
    public class PromptGenerator
    {
        public List<string> _prompts;
        
        public PromptGenerator()
        {
            _prompts = new List<string>
            {
                "Who was the most interesting person I interacted with today?",
                "What was the best part of my day?",
                "How did I see the hand of the Lord in my life today?",
                "What was the strongest emotion I felt today?",
                "If I had one thing I could do over today, what would it be?",
                "What is something I learned today?",
                "What made me smile today?",
                "What goal did I work toward today?",
                "Who did I help today and how?",
                "What am I grateful for today?"
            };
        }
        
        public string GetRandomPrompt()
        {
            Random random = new Random();
            int index = random.Next(_prompts.Count);
            return _prompts[index];
        }
    }
    
    // Journal class - manages a collection of entries
    public class Journal
    {
        public List<Entry> _entries;
        
        public Journal()
        {
            _entries = new List<Entry>();
        }
        
        public void AddEntry(Entry newEntry)
        {
            _entries.Add(newEntry);
        }
        
        public void DisplayAll()
        {
            if (_entries.Count == 0)
            {
                Console.WriteLine("No entries in the journal yet.");
                return;
            }
            
            Console.WriteLine("\n=== Journal Entries ===");
            foreach (Entry entry in _entries)
            {
                entry.Display();
                Console.WriteLine("-------------------");
            }
        }
        
        public void SaveToFile(string filename)
        {
            try
            {
                using (StreamWriter outputFile = new StreamWriter(filename))
                {
                    foreach (Entry entry in _entries)
                    {
                        outputFile.WriteLine(entry.GetFormattedEntry());
                    }
                }
                Console.WriteLine($"✅ Journal saved to '{filename}'");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"❌ Error saving file: {ex.Message}");
            }
        }
        
        public void LoadFromFile(string filename)
        {
            try
            {
                if (!File.Exists(filename))
                {
                    Console.WriteLine($"❌ File '{filename}' not found.");
                    return;
                }
                
                _entries.Clear();
                string[] lines = File.ReadAllLines(filename);
                
                foreach (string line in lines)
                {
                    string[] parts = line.Split('|');
                    
                    if (parts.Length == 3)
                    {
                        Entry loadedEntry = new Entry(parts[0], parts[1], parts[2]);
                        _entries.Add(loadedEntry);
                    }
                }
                
                Console.WriteLine($"✅ Journal loaded from '{filename}' - {_entries.Count} entries loaded.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"❌ Error loading file: {ex.Message}");
            }
        }
    }
    
    // Main Program
    class Program
    {
        static void Main(string[] args)
        {
            Journal journal = new Journal();
            PromptGenerator promptGenerator = new PromptGenerator();
            
            Console.WriteLine("🌟 Welcome to Your Personal Journal 🌟");
            Console.WriteLine("=====================================\n");
            
            bool running = true;
            while (running)
            {
                DisplayMenu();
                string choice = Console.ReadLine();
                
                switch (choice)
                {
                    case "1": // Write new entry
                        WriteNewEntry(journal, promptGenerator);
                        break;
                        
                    case "2": // Display all entries
                        journal.DisplayAll();
                        break;
                        
                    case "3": // Load from file
                        Console.Write("Enter filename to load from (e.g., 'myjournal.txt'): ");
                        string loadFile = Console.ReadLine();
                        journal.LoadFromFile(loadFile);
                        break;
                        
                    case "4": // Save to file
                        Console.Write("Enter filename to save to (e.g., 'myjournal.txt'): ");
                        string saveFile = Console.ReadLine();
                        journal.SaveToFile(saveFile);
                        break;
                        
                    case "5": // Quit
                        running = false;
                        Console.WriteLine("\n📝 Thank you for journaling today!");
                        Console.WriteLine("👋 Goodbye!");
                        break;
                        
                    default:
                        Console.WriteLine("❌ Invalid choice. Please enter 1-5.");
                        break;
                }
                
                if (running && choice != "2") // Don't pause after displaying entries
                {
                    Console.WriteLine("\nPress any key to continue...");
                    Console.ReadKey();
                }
                Console.WriteLine();
            }
        }
        
        static void DisplayMenu()
        {
            Console.WriteLine("===== JOURNAL MENU =====");
            Console.WriteLine("1. 📝 Write a new entry");
            Console.WriteLine("2. 📖 Display all entries");
            Console.WriteLine("3. 📂 Load journal from file");
            Console.WriteLine("4. 💾 Save journal to file");
            Console.WriteLine("5. 🚪 Quit");
            Console.Write("Select an option (1-5): ");
        }
        
        static void WriteNewEntry(Journal journal, PromptGenerator promptGenerator)
        {
            Console.WriteLine("\n===== NEW JOURNAL ENTRY =====");
            
            // Get random prompt
            string prompt = promptGenerator.GetRandomPrompt();
            Console.WriteLine($"\n💭 Prompt: {prompt}");
            
            // Get user response
            Console.Write("\n✍️  Your response: ");
            string response = Console.ReadLine();
            
            if (string.IsNullOrWhiteSpace(response))
            {
                Console.WriteLine("❌ Entry not saved - response was empty.");
                return;
            }
            
            // Get current date
            string date = DateTime.Now.ToString("MM/dd/yyyy hh:mm tt");
            
            // Create and add entry
            Entry newEntry = new Entry(date, prompt, response);
            journal.AddEntry(newEntry);
            
            Console.WriteLine($"\n✅ Entry added successfully on {date}!");
        }
    }
}