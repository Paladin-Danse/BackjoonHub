int cardCnt;
List<int> cardList = new List<int>();
if(int.TryParse(Console.ReadLine(), out cardCnt))
{
    for (int i = 1; i <= cardCnt; i++)
    {
        cardList.Add(i);
    }

    while(cardList.Count > 1)
    {
        Console.Write(cardList[0] + " ");
        cardList.Remove(cardList.First());
        cardList.Add(cardList.First());
        cardList.Remove(cardList.First());
    }
}
else
{
    Console.WriteLine("오류 : 잘못된 값 입력입니다.");
}

Console.WriteLine(cardList[0]);