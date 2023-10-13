using System.Diagnostics.CodeAnalysis;

public class Reference
{
    private string _chapter;
    private string _verse;
    private List<ScripWord> _scripWordList = new List<ScripWord>();

	public Reference(string chapter, string verse, string verseText)
    {
		_chapter = chapter;
		_verse = verse;
		string[] splitVerse = verseText.Split(" ");
		foreach (string element in splitVerse)
		{
			ScripWord newWord = new ScripWord(element);			
			_scripWordList.Add(newWord);
		}
    }

	public string GetChapter()
	{
		return _chapter;
	}
	public void SetChapter(string chapter)
	{
		_chapter = chapter;
	}
	public string GetVerse()
	{
		return _verse;
	}
	public void SetVerse(string verse)
	{
		_verse = verse;
	}
	public string GetReference()
	{
		return (_chapter + ":" + _verse);
	}
	public void HideRandomWord()
	{
        Random rnd = new Random();
		int selector = rnd.Next(0,_scripWordList.Count);
		_scripWordList[selector].SetHidden(true);
	}
	public void UnhideAll()
	{
		foreach (ScripWord i in _scripWordList)
		{
			i.SetHidden(false);
		}		
	}
    public string GetVerseText()
    {
		string output = "";
        foreach (ScripWord i in _scripWordList)
        {
            output = (output + i.GetHiddenWord());
        }
		return output;
    }

	public bool CheckAllHidden(){
		bool allWordsHidden = true;
        foreach (ScripWord i in _scripWordList)
        {
            if (i.GetHidden() == false ){
				allWordsHidden = false;
			}
        }
		return allWordsHidden;
	}
}