using System;
using System.Collections.Generic;

// ==============================================
// MAIN PROGRAM
// ==============================================
class Program
{
    static void Main(string[] args)
    {
        // Create a scripture with multiple verses
        Reference reference = new Reference("John", 3, 16, 17);
        Scripture scripture = new Scripture(
            reference,
            "For God so loved the world, that he gave his only begotten Son, " +
            "that whosoever believeth in him should not perish, but have everlasting life. " +
            "For God sent not his Son into the world to condemn the world; " +
            "but that the world through him might be saved."
        );

       Console.Clear();
        Console.WriteLine("SCRIPTURE MEMORIZER");
        Console.WriteLine("===================\n");
        Console.WriteLine("Instructions:");
        Console.WriteLine("- Press Enter to hide random words");
        Console.WriteLine("- Type 'quit' to exit at any time");
        Console.WriteLine("- Type 'show' to reveal all words\n");
        
        // Display initial scripture
        Console.WriteLine(scripture.GetDisplayText());
        Console.WriteLine("\nPress Enter to hide words, type 'quit' to show all words or exit.");
        
        // Main program loop
        while (!scripture.IsCompletelyHidden())
        {
            Console.Write("\n> ");
            string input = Console.ReadLine();
            
            if (input.ToLower() == "quit")
                break;
                
            if (input.ToLower() == "show")
            {
                // Reveal all words
                foreach (var word in scripture.GetType().GetField("_words", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance).GetValue(scripture) as List<Word>)
                {
                    word.Show();
                }
                
                Console.Clear();
                Console.WriteLine("SCRIPTURE MEMORIZER");
                Console.WriteLine("===================\n");
                Console.WriteLine(scripture.GetDisplayText());
                Console.WriteLine("\nPress Enter to hide words, type 'quit' to exit.");
                continue;
            }
            // Hide random words
            scripture.HideRandomWords(3);
            
            Console.Clear();
            Console.WriteLine("SCRIPTURE MEMORIZER");
            Console.WriteLine("===================\n");
            Console.WriteLine(scripture.GetDisplayText());
            
            if (!scripture.IsCompletelyHidden())
            {
                Console.WriteLine("\nPress Enter to hide more words, type 'quit' to exit.");
            }
            else
            {
                Console.WriteLine("\nAll words are hidden! Press any key to exit.");
            }
        }
        
        Console.WriteLine("\nProgram ended. Goodbye!");
        
        // EXCEEDS CORE REQUIREMENTS:
        // 1. Handles multiple verses in a single reference
        // 2. Randomly hides words each time (not just sequential)
        // 3. Allows user to quit at any time
        // 4. Shows progress with visual feedback
    }
}

// ==============================================
// SCRIPTURE CLASS
// ==============================================
public class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    private Random _random;
    
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();
        _random = new Random();
        
        // Split text into words and create Word objects
        string[] wordArray = text.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        foreach (string wordText in wordArray)
        {
            _words.Add(new Word(wordText));
        }
    }
    
    public void HideRandomWords(int numberToHide)
    {
        int wordsHidden = 0;
        
        // Try to hide the specified number of words
        while (wordsHidden < numberToHide && !IsCompletelyHidden())
        {
            int randomIndex = _random.Next(_words.Count);
            
            // Only hide if word isn't already hidden
            if (!_words[randomIndex].IsHidden())
            {
                _words[randomIndex].Hide();
                wordsHidden++;
            }
        }
    }
    
    public string GetDisplayText()
    {
        // Build the display text with reference and words
        string displayText = _reference.GetDisplayText() + "\n\n";
        
        foreach (Word word in _words)
        {
            displayText += word.GetDisplayText() + " ";
        }
        
        return displayText.Trim();
    }
    
    public bool IsCompletelyHidden()
    {
        // Check if all words are hidden
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
                return false;
        }
        return true;
    }
}

// ==============================================
// REFERENCE CLASS
// ==============================================
public class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;
    
    // Constructor for single verse
    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = verse;
    }
    
    // Constructor for verse range
    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = startVerse;
        _endVerse = endVerse;
    }
    
    public string GetDisplayText()
    {
        if (_verse == _endVerse)
        {
            // Single verse format: John 3:16
            return $"{_book} {_chapter}:{_verse}";
        }
        else
        {
            // Multiple verses format: John 3:16-17
            return $"{_book} {_chapter}:{_verse}-{_endVerse}";
        }
    }
}

// ==============================================
// WORD CLASS
// ==============================================
public class Word
{
    private string _text;
    private bool _isHidden;
    
    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }
    
    public void Hide()
    {
        _isHidden = true;
    }
    
    public void Show()
    {
        _isHidden = false;
    }
    
    public bool IsHidden()
    {
        return _isHidden;
    }
    
    public string GetDisplayText()
    {
        if (_isHidden)
        {
            // Replace each letter with underscore
            return new string('_', _text.Length);
        }
        else
        {
            return _text;
        }
    }
}