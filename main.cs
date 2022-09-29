using System;

class Program {
  public static void Main (string[] args) {

    

  string card = BingoCardMaker();

    Console.WriteLine(card);
//REPEATING NUMBERS???
    

  }

  static string BingoCardMaker (){
    bool repeater = true;
     Random rnd = new Random();

    while (repeater == true){
    int[,] BingoCard = new int[5, 5];
    
    for (int i = 0; i < 5; i++)
    {
    BingoCard[i,0] = rnd.Next(1,16);

    }

    for (int i = 0; i < 5; i++)
    {
    BingoCard[i,1] = rnd.Next(16,31);
    
    }

    for (int i = 0; i < 5; i++)
    {
    BingoCard[i,2] = rnd.Next(31,46);
    
    }
    for (int i = 0; i < 5; i++)
    {
    BingoCard[i,3] = rnd.Next(46,61);
    
    }
    for (int i = 0; i < 5; i++)
    {
    BingoCard[i,4] = rnd.Next(61,76);
    
    }

                                                                                                                                     

    
if(RepeatChecker(BingoCard)==true){
    string card="";

    card = "B \t I \t N \t G \t O \n";

    for(int i =0; i<5; i++)
    {
      for(int j =0; j<5; j++)
      {
        card += BingoCard[i,j]+"\t";
      }
      card += "\n";
     
    }
     repeater = false;
    return card;
}
    else{
      repeater = true;
    }

    }

    return "false";

  }

  static bool RepeatChecker(int[,] arr )
    
  {
    bool checker = false;
    bool stop  = false;
    while(checker == false){
      for(int i=0; (i<5)&& !stop; i++)
      {
        for(int j=1; (j<5)&& !stop; j++)
        {
          if(arr[i,j] == arr [j,i])
          {
            
            stop = true;
          }
          else
            checker = true;
        }
      }
    }
    
    return checker;
  }
}