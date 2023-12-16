using System.Runtime.CompilerServices;

class Video{

private string _uploader;
//length in seconds stored as an integer
private int _length;
private string _title;
private List<Comment> _comments; 
private int commentCount;

public Video(string title, string uploader, int length){

_title = title;
_uploader = uploader;
_length = length;
_comments = new List<Comment>();

}

public void addComment(string commenter, string text){
Comment comment = new Comment(commenter,text);
_comments.Add(comment);
}
public int GetCommentCount(){

commentCount = _comments.Count();
return commentCount;

}

public string getInformationString(){

   string stringy =$"{_title} by {_uploader}. Length: {_length/60} minutes. and {_length%60} seconds.  ";
   return stringy;
}


}