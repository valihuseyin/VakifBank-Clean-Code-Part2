using System;

namespace InterfafceSegregation
{
    class Program
    {
        static void Main(string[] args)
        {
           /*
            * Bir uygulamanın her işlevi, kendi arayüzüne sahip olmalı.
            * 
            * Bir fonksiyon, o nesnede kullanılmayacağı halde implemente ettiğiniz yapıdan dolayı mecburen geliyorsa bu prensibi ihlal ediyorsunuz.
            */


        }
    }

    public interface IMessage
    {
        string From { get; set; }
        string To { get; set; }
        string Body { get; set; }
        string Subject { get; set; }
       
    }

    public interface IVideoMessage: IMessage
    {
       
        int VideoDuration { get; set; }
    }

    public interface IImageMessage:IMessage
    {
        string ImageFormat { get; set; }
    }

    public class TextMessage : IMessage
    {
        public string From { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string To { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Body { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Subject { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }

    public class VideoMessage : IVideoMessage
    {
        public int VideoDuration { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string From { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string To { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Body { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Subject { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }

    public class ImageMessage : IImageMessage
    {
        public string ImageFormat { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string From { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string To { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Body { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Subject { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }


}
