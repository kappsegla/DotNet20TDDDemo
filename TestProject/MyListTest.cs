using DotNet20Demo;
using Xunit;


namespace TestProject
{
    public class MyListTest
    {

        [Fact]
        public void MyList_Should_Be_Empty_After_Creation()
        {
            MyList myList = new MyList();

            Assert.Equal(0, myList.Size());
        }

        [Fact]
        public void Add_One_Item_Should_Return_One_As_Size()
        {
            MyList myList = new MyList();

            myList.Add(1);

            Assert.Equal(1, myList.Size());
        }

        [Fact]
        public void Add_One_Item_Should_Return_One_From_Get()
        {
            MyList myList = new MyList();

            myList.Add(1);

            Assert.Equal(1, myList.Get(0));
        }
        [Fact]
        public void Add_Two_Items_Should_Be_Able_To_Get_Both()
        {
            MyList myList = new MyList();

            myList.Add(1);
            myList.Add(5);
            
            Assert.Equal(1, myList.Get(0));
            Assert.Equal(5, myList.Get(1));
            Assert.Equal(2, myList.Size());
        }
    }
}
