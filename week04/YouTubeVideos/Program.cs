using System;

class Program
{
    static void Main(string[] args)
    {
        
        Video video1 = new Video("Every Way to Screw Up Steak | Botched By Babish ", "Babish Culinary Universe", 2134);
        Video video2 = new Video("I Build 3 Cutting Boards - 5 Min vs. 5 Hour vs. 5 Day", "John Malecki", 2053);
        Video video3 = new Video("These One Pot Dinners Will Make Your Life Easier ", "LifebyMikeG", 1133);

        video1.AddComment(new  Comments("qaszim2012", "As said by many others, this 8s so much more informative than a single recipe done right." +
        " The world needs more of these type of videos on every topic.\n"));
        video1.AddComment(new  Comments("billyjoe3309", "You literally touched on all the problems I've faced and I started to get frustrated." +
        " This video shall be my new guide in life!\n"));
        video1.AddComment(new  Comments("cekuhnen", "This is superior - not only to show what works but also what does not work and explaining the WHY !!!!\n"));


        video2.AddComment(new  Comments("pewsician2388", "I've gotta say, I honestly like the 5 minute board the best. I definitely appreciate the time and skill\n" +
        " that went into the 5 day board, but the simplicity of a beautiful live edge board just does it for me.\n"));
        video2.AddComment(new  Comments("Giant_Guitars", "Etsy sellers be selling that 5 minute one for $324.62 + shipping\n"));
        video2.AddComment(new  Comments("jacibrown2717", "That 5 day is STUNNING.  Honestly the 5 min is too bc it highlights the wood. Awesome to watch a master play.\n"));

        video3.AddComment(new  Comments("jigga1017","Mike will you do a few meals specifically the using steam function on a rice cooker, along with a few general " +
        "rice cooker recipes that don't involve rice?\n"));
        video3.AddComment(new  Comments("kbdefay", "I love these one pot (pan) meal ideas!\n"));
        video3.AddComment(new  Comments("BSGSV","You never fail to come up with real bangers.\n"));
        video3.AddComment(new  Comments("nicolebell-m1y","One of your best vids in a long time 🤩 THANK YOU!! 🙏🏼 Saved and recipes will be made. Thanks Mike!\n"));


        var videos = new List<Video> {video1, video2, video3};

        foreach (var video in videos)
        {
            Console.WriteLine(video);
            Console.WriteLine(new string('-', 40));
        }
    }
}