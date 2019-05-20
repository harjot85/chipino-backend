﻿using backend_website.Models;
using System;
using System.Collections.Generic;
using System.IO;

namespace backend_website.Data
{
    public class DummyData : IRepositoryData
    {
        public IEnumerable<Content> GetTextContent()
        {
            var textContent = new List<Content>()
            {
                new Content(){ Id=0,PageData="Home Page Text", Description="This test is located on Home Page."},
                new Content(){ Id=1,PageData="Portfolio Page Text", Description="This text is location on Portfolio Page."},
                new Content(){ Id=2,PageData="Contact Us Page Text", Description="This text is located on Contact Us page."},
                new Content(){ Id=3,PageData="About Chipino Page Text", Description="This text in on About Chipino page."},
                new Content(){ Id=4,PageData="Support text Text", Description="This text is locaged here and tere."},
                new Content(){ Id=5,PageData="Some other text on a Page", Description="This text will be on some other part of the page."},
            };
            return textContent;
        }

        public IEnumerable<Media> GetMediaContent()
        {
            byte[] imgOne = File.ReadAllBytes("./wwwroot/Images/1.png");
            byte[] imgTwo = File.ReadAllBytes("./wwwroot/Images/2.png");

            var mediaContent = new List<Media>()
            {
                new Media(){ Id=10, FileContent=Convert.ToBase64String(imgOne), FileType="data:image/png;base64", FileDescription="This is Picture One with NO undelying text."  },
                new Media(){ Id=11, FileContent=Convert.ToBase64String(imgTwo), FileType="data:image/png;base64", FileDescription="This is Picture Two with undelying text."  },
            };
            return mediaContent;
        }

        public IEnumerable<Footer> GetFooterContent()
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
