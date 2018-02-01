using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    class Picture
    {

        // titles of images in pictures
        string[] pictures = new string[16]
            {
                "candy1.jpg",
                "candy2.jpg",
                "candy3.jpg",
                "candy4.jpg",
                "candy5.jpg",
                "candy6.jpg",
                "candy7.jpg",
                "candy8.jpg",
                "candy9.jpg",
                "candy10.jpg",
                "candy11.jpg",
                "candy12.jpg",
                "candy13.jpg",
                "candy14.jpg",
                "candy15.jpg",
                "candy16.jpg"
            };


        // rshuffled titles
        public string[] setPictures = new string[16];

        // the target picture title
        public string targetPic = "";
        // list for storing random numbers
        Random rand = new Random();
        
        public Picture()
        {

            for (int i=0;i<16;i++)
            {
                setPictures[i] = "";
            }
        }

        int[] nums;
        public void mapPictures()
        {
            int index  = rand.Next(1,16);
            targetPic= pictures[index];

            randomize();
            setPictures[nums[0]] = targetPic;
            setPictures[nums[1]] = targetPic;
            setPictures[nums[2]] = targetPic;

            for (int i=1;i<16;i++)
            {
                setPictures[nums[i]] = pictures[i];
            }
        }

        public void randomize()
        {
            nums = Enumerable.Range(0, 16).ToArray();
            var rnd = new Random();

            // Shuffle the array
            for (int i = 0; i < nums.Length; ++i)
            {
                int randomIndex = rnd.Next(nums.Length);
                int temp = nums[randomIndex];
                nums[randomIndex] = nums[i];
                nums[i] = temp;
            }


        }



        // this method will generate a list of 16 random numbers
        // end of randomize



    }
}
