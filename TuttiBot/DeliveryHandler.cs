﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuttiBot
{
    class DeliveryHandler
    {
        private string provider;
        private Pushover pushover;

        public DeliveryHandler(string provider)
        {
            this.provider = provider;
            switch (provider)
            {
                case "pushover":
                    //MAYBE CHANGE THIS SO NOT FOR EVERY MESSAGE A NEW OBJECT HAVE TO BE CREATED
                    this.pushover = new Pushover("uoGz5xaAPxZQFGDJwPhEF3vJF6eeYG", "ae965hsnhmamdo12wcpmxw75fto72a");
                    break;
                case "telegram":
                    Console.WriteLine("Telegram is not yet implemented!");
                    break;
            }

        }

        public void sendTextOnly(Offer offer)
        {

            switch (provider)
            {
                case "pushover":
                    pushover.pushText(offer.ToString());
                    break;
                case "telegram":
                    Console.WriteLine("Telegram is not yet implemented!");
                    break;
            }

        }

        public async void sendCompleteAsync(Offer offer)
        {
            
            switch (provider)
            {
                case "pushover":
                    await pushover.pushImage(offer.ToString(), offer.thumb_url);
                    break;
                case "telegram":
                    Console.WriteLine("Telegram is not yet implemented!");
                    break;
            }

        }



    }



}