string[] list = {"hello", "2", "world", ":-)"};
string[] new_list;

for(int i = 0; i <= list.Length; i++){
  if(list[i].Length <= 3){
    new_list[new_list.Length] = list[i];
  }
}
Console.WriteLine(new_list);