public class Scripture
{
    private string _chapter;
    private List<Reference> _refList = new List<Reference>();
	public Scripture(string chapter, int verse, string verseText)
    {
		_chapter = chapter;
		Reference newRef = new Reference(chapter, "" + verse, verseText);
        _refList.Add(newRef);
    }
	public Scripture(string chapter, int verseStart, int verseEnd, string verseText)
    {
		_chapter = chapter;
        string[] verseTextSplit = verseText.Split("~|~");
        int startIt = 0;
        for (int i = verseStart; i <= verseEnd; i++) 
        {
            Reference newRef = new Reference(chapter, "" + i, verseTextSplit[startIt++]);
            _refList.Add(newRef);
        }
    }

    public void HideRandom(){ 
        foreach (Reference i in _refList)
        {
            i.HideRandomWord();
            i.HideRandomWord();
        }
    }
    public void Unhide(){ 
        foreach (Reference i in _refList)
        {
            i.UnhideAll();
        }
    }
    public void Display()
    {
        string output = _chapter + ":" + _refList[0].GetVerse();
        string lastVerse = "";
        string textOut = "";
        foreach (Reference i in _refList)
        {
            lastVerse = i.GetVerse();
            textOut = textOut + i.GetVerseText();
        }
        if( _refList[0].GetVerse().Equals(lastVerse)){
            output = output + " " + textOut;
        }
        else{
            output = output + "-" + lastVerse + " " + textOut;
        }
        Console.WriteLine(output);
    }
    
    public void DisplaySpecific(string verse)
    {
        string output = _chapter + ":";
        string textOut = "";
        foreach (Reference i in _refList)
        {
            if (i.GetVerse().Equals(verse)){
                textOut = i.GetVerseText() + " ";
            }
        }
        Console.WriteLine( _chapter + ":" + verse + " " + textOut);
    }
    public bool HiddenStatus()
    {
        bool allHidden = true;
        foreach (Reference i in _refList)
        {
            if (i.CheckAllHidden() == false){
                allHidden = false;
            }
        }
        return allHidden;
    }
}