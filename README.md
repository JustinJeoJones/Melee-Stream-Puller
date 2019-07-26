<h1>Melee-Stream-Puller V1.1</h1>
<h2>This app makes running streams easier by pulling down the matches automatically. You can hook it up with obs to allow the stream to update as you select new matches.</h2>
<h2>How to download: </h2>
<ul>
  <li>First click the "CLICK HERE TO DOWNLOAD" rar file.</li>
  <li>Once clicked, there should be a download button</li>
  <li>Once downloaded use winrar/7zip/some alternative to export it.</li>
</ul>
<h2>How to run</h2>
<ul>
  <li>First look through the files for MeleeStreamInfo</li>
  <li>Run it</li>
  <li>Take the link to your bracket and put it in the text box on the top right</li>
  <ul>
    <li>https://smash.gg/tournament/get-on-my-level-2019-canadian-fighting-game-championships/events/super-smash-bros-melee-singles/brackets/587941/979311 (Notice how they are into a specific bracket. Will not work unless you are in the requested bracket)</li>
    <li>https://challonge.com/smashatgeekgroup72melee</li>
  </ul>
  <li>Once entered, click "Find/Update" to pull the matches</li>
  <li>Once loaded, click the match you wish to have on stream</li>
  <li>You will see the text boxes on the right update. Click "Update" to update the text files.</li>
</ul>
<h2>Setting up OBS support</h2>
<ul>
  <li>Load up OBS</li>
  <li>Go to the sources box and click the +</li>
  <li>Click Text</li>
  <li>Enter the name for the text file you want (currently supports player 1 and 2's name, the name of the tournament, and the round)</li>
  <li>Click read from file</li>
  <li>New boxes should show up, look for text file and click the browse button</li>
  <li>Look for the assests folder and then find the matching file</li>
  <li>Click ok it should be added</li>
</ul>
<h2>If you have your own xml file</h2>
<ul>
  <li>Required nodes</li>
  <ul>
    <li>/items/pName1</li>
    <li>/items/pName2</li>
    <li>/items/gTitle  (tournament name)</li>
    <li>/items/gTitle2  (round name)</li>
    <li>/items/pScore1</li>
    <li>/items/pScore2</li>
  </ul>
  <li>Launch the app</li>
  <li>Click xml file search</li>
  <li>Find your file</li>
  <li>Add it. If there is no issues it works.</li>
  <li>Once it is set up once you shouldn't need to do it again</li>
</ul>
