using backend_website.Models;
using System;
using System.Collections.Generic;
using System.IO;

namespace backend_website.Data
{
    public class DummyData
    {
        public IEnumerable<Content> TextContent { get; set; }
        public IEnumerable<Media> MediaContent { get; set; }
        public IEnumerable<Footer> FooterContent { get; set; }

        public DummyData()
        {
            TextContent = GetTextContent();
            MediaContent = GetMediaContent();
            FooterContent = GetFooterContent();
        }

        private List<Content> GetTextContent()
        {
            var textContent = new List<Content>()
            {
                new Content(){ Id=0,ContentText="Home Page Text", Description="This test is located on Home Page."},
                new Content(){ Id=1,ContentText="Portfolio Page Text", Description="This text is location on Portfolio Page."},
                new Content(){ Id=2,ContentText="Contact Us Page Text", Description="This text is located on Contact Us page."},
                new Content(){ Id=3,ContentText="About Chipino Page Text", Description="This text in on About Chipino page."},
                new Content(){ Id=4,ContentText="Support text Text", Description="This text is locaged here and tere."},
                new Content(){ Id=5,ContentText="Some other text on a Page", Description="This text will be on some other part of the page."},
            };
            return textContent;
        }

        private List<Media> GetMediaContent()
        {
            byte[] imgOne = File.ReadAllBytes("./wwwroot/Images/1.png");
            byte[] imgTwo = File.ReadAllBytes("./wwwroot/Images/1.png");

            var mediaContent = new List<Media>()
            {
                new Media(){ Id=10, MediaContent=Convert.ToBase64String(imgOne) , Description="This is Picture One wiht NO undelying text."  },
                new Media(){ Id=11, MediaContent=Convert.ToBase64String(imgTwo) , Description="This is Picture Two wiht undelying text."  },
            };
            return mediaContent;
        }

        private List<Footer> GetFooterContent()
        {
            var footerContent = new List<Footer>()
            {
                new Footer(){ Id=501, IconClass="fab fa-github", Height="36px",Width="36px", LinkTo="github.com", HoverColor="#289CCB"  },
                new Footer(){ Id=502, IconClass="fab fa-medium-m", Height="36px",Width="36px", LinkTo="medium.com", HoverColor="#A9EAD2"  },
                new Footer(){ Id=503, IconClass="fab fa-reddit-alien", Height="36px",Width="36px", LinkTo="reddit.com", HoverColor="#FF8B94"  },
            };
            return footerContent;
        }
    }
}
