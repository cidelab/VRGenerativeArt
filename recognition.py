import speech_recognition as sr
import requests
from time import time

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
        # print("Microsoft Bing Voice Recognition could not understand audio")
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
	print('get words : ' + words)
	url = 'http://localhost:4000?words=' + words
	sendRequest(url)
	return

def listenAndCompute():
    while True:
        audio = listenMicrophone()
        output = convertToText(audio)
        if output:
            if output is not 'stop':
                sendWords(output)
            else:
                break
    return

if __name__ == "__main__":
    BING_KEY = "d6d31a805fca4a9187b7c797fcc50bef" # Microsoft Bing Voice Recognition API keys 32-character lowercase hexadecimal strings
    r = sr.Recognizer()
    # function to update the file
    listenAndCompute()
