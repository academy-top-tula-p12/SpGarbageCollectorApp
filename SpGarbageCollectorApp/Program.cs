
unsafe
{
    int n = 120;
    int* ptr = &n;
    Console.WriteLine($"{*ptr}");

    Node node = new();
    Node* nodePointer = &node;
    nodePointer->Name = "Peet";


    int[] nums = [1, 2, 3, 4, 5];
    fixed(int* iptr = nums)
    {
        Console.WriteLine(*(iptr+2));
    }
      


    //Method(out userPointer);
    //GC.Collect();
    //{
    //    User user = new User();
    //    userPointer = &user;
    //}
    //GC.Collect();

    //userPointer->Name = "user";


    //Console.WriteLine(userPointer->Name);





    int* array = stackalloc int[10];
    int[] arr = new int[10];

}


unsafe void Method(out User* userPointer)
{
    User user = new();
    user.Name = "Bobby";
    userPointer = &user;
}

unsafe struct ValueStruct
{
    int* ptr;
}

unsafe class PtrClass
{
    int* ptr;
}

class User
{
    public string Name { get; set; }
}

struct Node
{
    public string Name;
}
