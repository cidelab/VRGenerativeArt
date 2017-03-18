import speech_recognition as sr

# obtain audio from the microphone
r = sr.Recognizer()
with sr.Microphone() as source:
    print("Do you want a cube?")
    audio = r.listen(source)

# recognize speech using Microsoft Bing Voice Recognition
BING_KEY = "d6d31a805fca4a9187b7c797fcc50bef" # Microsoft Bing Voice Recognition API keys 32-character lowercase hexadecimal strings
try:
    output = r.recognize_bing(audio, key=BING_KEY, language = "en-US", show_all = False)
except sr.UnknownValueError:
    print("Microsoft Bing Voice Recognition could not understand audio")
except sr.RequestError as e:
    print("Could not request results from Microsoft Bing Voice Recognition service; {0}".format(e))
  
x = "cube" #eventually we put the unity adress for the cube
if output == "yes":
    print (x)  #insert cube into VR

else:
    None 
    

k = sr.Recognizer()
with sr.Microphone() as source:
    print("Do you want a cube?")
    audio = k.listen(source)

# recognize speech using Microsoft Bing Voice Recognition
BING_KEY = "d6d31a805fca4a9187b7c797fcc50bef" # Microsoft Bing Voice Recognition API keys 32-character lowercase hexadecimal strings
try:
    output = k.recognize_bing(audio, key=BING_KEY, language = "en-US", show_all = False)
except sr.UnknownValueError:
    print("Microsoft Bing Voice Recognition could not understand audio")
except sr.RequestError as e:
    print("Could not request results from Microsoft Bing Voice Recognition service; {0}".format(e))

output_2 = r.recognize_bing(audio, key=BING_KEY, language = "en-US", show_all = False)

if output_2 == "yes":
    print ("you have streched cube now")
else:
    print("you have a cube")
    
