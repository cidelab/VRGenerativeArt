import time, sys
from pygame import mixer # Load the required library

mixer.init()
mixer.music.load('audio/yellow.mp3')
mixer.music.play()

time.sleep(5)