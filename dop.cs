Console.Clear();
Console.WriteLine("введите последовательность чисел ");
int n= Convert.ToInt32(Console.ReadLine());
int max1=n;
int max2=n;
while(n!=0){
    n= Convert.ToInt32(Console.ReadLine());
    if (max2<n && max2<max1){
        max2=max1;
    }else if(max2>n && max2==max1){
        max2=n;
    }
    if(max1<n){
        max1=n; 
    }
}
Console.WriteLine(max2);