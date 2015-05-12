using ClassUtilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ClassUtilitiesTests
{
    public class StringListTests
    {
        [Fact]
        public void Constructor_HasCountOfZero_WhenThereAreNoParameters()
        {
            StringList list = new StringList();
            Assert.Equal(0, list.Length);
        }

        [Theory]
        [InlineData(3)]
        [InlineData(0)]
        [InlineData(100)]
        public void Constructor_HasCountOfThree_WhenExistingArrayHasThreeItems(int size)
        {
            string[] passedInArray = new string[size];
            StringList list = new StringList(passedInArray);
            Assert.Equal(size, list.Length);
        }

        [Fact]
        public void Constructor_HasSameItems_AsPassedInArray()
        {
            var passedInArray = new[] { "Foo", "Bar" };
            StringList list = new StringList(passedInArray);
            Assert.Equal("Foo", list.Get(0));
            Assert.Equal("Bar", list.Get(1));
        }

        [Fact]
        public void Constructor_StringListDoesntChange_WhenPassedInArrayChanges()
        {
            var passedInArray = new[] { "Foo", "Bar" };
            StringList list = new StringList(passedInArray);
            passedInArray[0] = "Baz";
            Assert.Equal("Foo", list.Get(0));
            Assert.Equal("Bar", list.Get(1));
        }

        [Fact]
        public void Add_ListHasItem_WhenItemIsAdded()
        {
            StringList list = new StringList();
            list.Add("Foo");
            Assert.Equal("Foo", list.Get(0));
        }

        [Fact]
        public void Add_ListCountIncreasesByOne_WhenNewItemIsAdded()
        {
            StringList list = new StringList();
            list.Add("Foo");
            Assert.Equal(1, list.Length);
        }

        [Fact]
        public void Clear_LengthIsSetToZero()
        {
            StringList list = new StringList(new[] { "Foo", "Bar" });
            list.Clear();
            Assert.Equal(0, list.Length);
        }

        [Fact]
        public void CheckArray_ToSeeIf_Copied()
        {
            var passedInArray = new[] { "Foo" };
            StringList list = new StringList(passedInArray);
            string[] test = list.GetArray();
            Assert.Equal("Foo", test[0]);
        }

        [Fact]
        public void Remove_WhenItemHasBeenRemoved()
        {
            StringList list = new StringList(new[] { "Foo", "Bar", "Baz" });
            list.Remove(1);
            Assert.Equal("Foo", list.Get(0));
            Assert.Equal("Baz", list.Get(1));
        }
    }
}
