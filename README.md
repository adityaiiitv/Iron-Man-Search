# Iron-Man-Voice-Image-Search

Tony Stark asks Jarvis to search for something and present either an augmented version or a hologram of the result. I tried to make my Jarvis return some image results for me. This application helps you to get the images and project them in augmented reality.

Future extension: Will try to incorporate the feature into HoloLens or Magic Leap.

![Say "Donald Trump"](https://github.com/adityaiiitv/Iron-Man-Voice-Image-Search/blob/master/4.PNG)
Say out loud "Donald Trump"

![The President is here](https://github.com/adityaiiitv/Iron-Man-Voice-Image-Search/blob/master/5.PNG)
The President is here

Working:

(1) Call the microphone to listen for speech

(2) Process speech using IBM Watson Unity plugin

(3) Create a google search query and get the resulting JSON using Google Custom Search API

(4) Use Vuforia's ground plane detection

(5) Augment the images in the image prefab, display the prefab over the ground plane

Tools: Unity, C#, IBM Watson, Google Custom Search API

Let us meet the President

![Pressing the button after saying "Hello"](https://github.com/adityaiiitv/Iron-Man-Voice-Image-Search/blob/master/1.PNG)
Say out loud "Hello" and press the button for magic

![Resulting images augmented in the reality](https://github.com/adityaiiitv/Iron-Man-Voice-Image-Search/blob/master/2.PNG)
Viola!

![Resulting images augmented in the reality](https://github.com/adityaiiitv/Iron-Man-Voice-Image-Search/blob/master/3.PNG)
