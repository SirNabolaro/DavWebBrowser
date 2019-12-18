﻿using GTANetworkAPI;
using Newtonsoft.Json;
using Browsers.Models.BrowserModels;
using Browsers.Models.BrowserModels.Elements;
using System.Collections.Generic;
using System.Linq;
using DavWebCreator.Server.Models.Browser.Elements;
using DavWebCreator.Server.Models.Browser.Elements.Fonts;

namespace DavWebCreator.Events
{
    public class BrowserEvents : Script
    {
        public BrowserEvents()
        {

        }

        /// <summary>
        /// Generates the following CEF Browser ->
        /// <div>
        ///     <h1>Title</h1>
        ///     <input type="button"/>
        ///     <input type="button"/>
        /// </div>
        /// </summary>
        /// <param name="player"></param>
        [Command("b")]
        public void CreateExampleBrowser(Client player)
        {
            Browser browser = new Browser("ExampleBrowser", BrowserType.Custom, Position.Mid_Left, "100%", "100%");


            //var loginContainer = new BrowserContainer(Position.Mid);


            // The html elements are ordered in the same way you add them to the browser elements.
            browser.AddElement(new BrowserTitle(Position.Top_Left, "Hello", "42px", "Arial", true, "100%", "50px", "blue", BrowserTextAlign.center));
            browser.AddElement(new BrowserTitle(Position.Top_Mid, "Hello2", "32px", "Arial", false, "100%", "50px", "black", BrowserTextAlign.left));
            browser.AddElement(new BrowserTitle(Position.Top_Right, "Hello2", "32px", "Arial", false, "100%", "50px", "black", BrowserTextAlign.right));

            browser.AddElement(new BrowserCheckBox(Position.Top_Left, "Are you fish?", false, "16px", "Arial", false, "16px", "16px", BrowserTextAlign.left));

            browser.AddElement(new BrowserTitle(Position.Mid_Left, "Hello3", "16px", "Arial", false, "100%", "100px", "grey", BrowserTextAlign.center));
            browser.AddElement(new BrowserText(Position.Mid, "som long text that i should write but i have no clue what i should write so i will let my....",
                                    "12px", "Arial", true, "red", "100%", "100px", BrowserTextAlign.right));

            browser.AddElement(new BrowserTitle(Position.Mid_Right, "Hello", "42px", "Arial", true, "100%", "50px", "blue", BrowserTextAlign.right));
            browser.AddElement(new BrowserTitle(Position.Bottom_Left, "Hello2", "32px", "Arial", false, "100%", "50px", "black", BrowserTextAlign.center));
            browser.AddElement(new BrowserTitle(Position.Bottom_Mid, "Hello2", "32px", "Arial", false, "100%", "50px", "black", BrowserTextAlign.left));
            browser.AddElement(new BrowserTitle(Position.Bottom_Right, "Hello2", "32px", "Arial", false, "100%", "50px", "black", BrowserTextAlign.center));


            //// Title
            //    loginContainer.AddElement(new BrowserTitle(Position.Mid, "Hello", "12px", bold: true));

            //    // Input fields
            //    var userNameTextBox = new BrowserTextBox(Position.Mid, "type....", "Username", readOnly: false);
            //    loginContainer.AddElement(userNameTextBox);

            //    var passwordTextBox = new BrowserTextBox(Position.Bottom_Mid, "type...", "Password", readOnly: false);
            //    loginContainer.AddElement(passwordTextBox);

            //    // Remember Password
            //    var rememberPasswordCheckBox = new BrowserCheckBox(Position.Bottom_Mid, "Remember password", false);
            //    loginContainer.AddElement(rememberPasswordCheckBox);

            //    // Login Button
            //    var loginButton = new BrowserButton(Position.Bottom_Mid, "Einloggen", "12px", "LOGIN_REMOTE_EVENT");

            //    // Click on the button will call the "LOGIN_REMOTE_EVENT" on the Server side and returns the following browser elements to the specifig type you define.
            //    loginButton.AddReturnObject(userNameTextBox.Id, typeof(string));
            //    loginButton.AddReturnObject(passwordTextBox.Id, typeof(string));
            //    //loginButton.AddReturnObject(rememberPasswordCheckBox.Id, typeof(bool));

            //    // Add the button to the container
            //    loginContainer.AddElement(loginButton);

            //// Add the login (div)Container to the Browser's elements
            //browser.Elements.Add(loginContainer);

            // Open CEF with desired width and height

            browser.OpenBrowser(player);
        }

        [RemoteEvent("LOGIN_REMOTE_EVENT")]
        public void LogMeIn(Client player, string username, string password, bool rememberPasswordCheckbox)
        {
            // Do stuff
        }



        //[RemoteEvent("BROWER_CLOSED", typeof(Browser))]
        //public void BrowserJustClosed(Client player, Browser browser)
        //{
        //    player.SendChatMessage("Browser closed");
        //}


        public void CloseBrowser()
        {

        }
    }
}
