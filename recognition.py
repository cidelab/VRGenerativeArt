import speech_recognition as sr
import requests
import random
from time import time
from pygame import mixer # Load the required library
##### HELPER FUNCTIONS TO CONVERT SPEECH TO TEXT USIGN MSFT BING SPEECH API

##### MODIFY process for whatever preprocessing you want to do

def process(output):
    """
    Whatever preprocessing step you want to do strings recognized
    """

    return output

def listenMicrophone():
    print('I am listening!')
    with sr.Microphone() as source:
        audio = r.listen(source)
    return audio

# recognize speech using Microsoft Bing Voice Recognition
def convertToText(audio):
    try:
        output = r.recognize_bing(audio, key=BING_KEY, language = "en-US", show_all = False)
    except sr.UnknownValueError:
        print("Microsoft Bing Voice Recognition could not understand audio")
        #if random.random() <= 0.34 :
        	#playAudio('audio/not_understand.mp3')
        output = None
    except sr.RequestError as e:
        print("Could not request results from Microsoft Bing Voice Recognition service; {0}".format(e))
        output = None
    return output

def sendRequest(url):
	r = requests.get(url)

def sendWords(words):
	"""
	Send words to unity, which is constantly read by unity
	"""
	try:
		print('You said : ' + words)
		url = 'http://localhost:4000?' + words
		sendRequest(url)
	except IOError:
		print('Error in the connection.')

def listenAndCompute():
    dict = {}
    count = 0
    while True:
        audio = listenMicrophone()
        output = convertToText(audio)
        if output:
            count += 1
            if output is not 'stop':
                sendWords(output)
                #if 'yellow' in output :
                	#dict['yellow'] = 1
                #elif 'left' in output :
                	#dict['left'] = 1
                #if count >= 5 and not 'yellow' in dict :
                	#playAudio('audio/yellow.mp3')
              #  elif count >= 5 and not 'left' in dict :
                	#playAudio('audio/move_left.mp3')
            else:
                break
    return

def playAudio(path):
	mixer.init(frequency=2000)
	# 'audio/yellow.mp3'
	mixer.music.load(path) 
	mixer.music.play()
	while mixer.music.get_busy() == True:
		continue

if __name__ == "__main__":
    BING_KEY = "5171bbb6346d4da8a02a00c06f248280" #"d6d31a805fca4a9187b7c797fcc50bef" # Microsoft Bing Voice Recognition API keys 32-character lowercase hexadecimal strings
    r = sr.Recognizer()    
    #playAudio('audio/new_cube.mp3')
    # function to update the file
    listenAndCompute()
