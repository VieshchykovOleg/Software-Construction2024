using System;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        TextEditor editor = new TextEditor();

        editor.Type("Перший рядок тексту.\n");
        Console.WriteLine(editor.Print()); // Виведе перший рядок тексту

        editor.Type("Другий рядок тексту.\n");
        Console.WriteLine(editor.Print()); // Виведе перший рядок тексту. Другий рядок тексту

        editor.Undo();
        Console.WriteLine(editor.Print()); // Виведе перший рядок тексту

        editor.Type("Третій рядок тексту.\n");
        Console.WriteLine(editor.Print()); // Виведе перший рядок тексту. Третій рядок тексту

        editor.Undo();
        Console.WriteLine(editor.Print()); // Виведе перший рядок тексту

        editor.Undo();
        Console.WriteLine(editor.Print()); // Виведе пустий рядок
    }
}

