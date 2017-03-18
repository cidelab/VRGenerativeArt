import speech_recognition as sr

# obtain audio from the microphone
r = sr.Recognizer()
with sr.Microphone() as source:
    print("Say something!")
    audio = r.listen(source)

# recognize speech using Microsoft Bing Voice Recognition
BING_KEY = "d6d31a805fca4a9187b7c797fcc50bef" # Microsoft Bing Voice Recognition API keys 32-character lowercase hexadecimal strings
try:
    output = r.recognize_bing(audio, key=BING_KEY, language = "en-US", show_all = False)
except sr.UnknownValueError:
    print("Microsoft Bing Voice Recognition could not understand audio")
except sr.RequestError as e:
    print("Could not request results from Microsoft Bing Voice Recognition service; {0}".format(e))
  
x = "cube"
if output is "yes":
    print x 

else:
    none 
