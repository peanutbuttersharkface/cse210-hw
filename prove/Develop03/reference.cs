using System;

public class Reference{
    private string _book;
    private string _chapter;
    private string _verse;
    private string _endVerse;
    private string _text;

    public void SetBook(string book){
        _book = book;
    }

    public void SetChapter(string chapter){
        _chapter = chapter;
    }

    public void SetVerse(string verse){
        _verse = verse;
    }

    public void SetEndVerse(string endVerse){
        _endVerse = endVerse;
    }
    public string GetText(){
        return _text;
    }
  

    public Reference(string book, string chapter, string verse, string text){
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _text = text;
    }
    public Reference(string book, string chapter, string verse, string endVerse, string text){
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = endVerse;
        _text = text;
    }


    
    public string Display(){  
        string scriptRef =$"{_book} {_chapter}: {_verse}{_endVerse}";
        return scriptRef;

    }
}