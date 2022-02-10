# AnimeGifBot  
<section>
<p>Hi, I made this bot using the Discord api. Its purpose is to send anime gifs related to a hardcoded list of anime + general anime when anyone in the chat requests a random gif.
I would like to eventually add a functionality that will allow the bot to send a gif related to an anime whenever a user mentions anything to do with that anime. i also want it to be able 
to play tect based games with the chatters.</p>
<p>This bot has to be running on your local machine for it to work and you have to invite it to whatever servers you want it to operate in. If you want it to run 24/7 with your computer off,
then you have to upload the code into a third party code storage database like https://replit.com, then link it to https://uptimerobot.com/</p>
<h1>Resources Used</h1>
  <p>https://discord.com/developers<p>
    <h1>Discord api documentation</h1>
      <p2>https://discord.com/developers/docs/intro</p2>
  <p2>https://tenor.com/gifapi</p2>
    <h1>Tenor api documentation</h1>
      <p2>https://tenor.com/gifapi/documentation#quickstart</p2>
<h2>Setup</h2>
  <p1>I removed my api keys in two places in the code, so before this bot can be ran you need to get your won apikey and paste them into the rquired firelds</p1>
    <p2>To get an api key(token) from discord, just go to the developer portal and sign in, then select new application and follow through the process. Then in setting, click on the bot tab
    and under the username there should be an option to reveal your token. Copy and paste that into the token string in AnimeGifBot Program.cs</p2>
    <h2>OAuth2 Discord</h2>
      <p1>In Discord, go to the OAuth2 tab and select URL Generator in the sub tab. My setting are bot -> Administrator. Then at the bottom copy the url and paste it in the 
      Custom URL field in OAuth2 -> General</p1>
    <p3>To get an api key from Tenor, click on the Tenor link for documentation, in the top right click get free API Key. Follow the steps and copy paste your key into 
    AnimeGifBot -> Commands.cs -> string tenorKey</p3>
</section>   
  
