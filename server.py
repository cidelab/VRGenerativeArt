import requests
from flask import Flask

app = Flask(__name__)

@app.route("/")
def hello():
	url = 'http://localhost:4000/test/color?test=aaa&test2=123&test3=aw4'
	sendRequest(url)
	return "done"

def sendRequest(url):
	r = requests.get(url)


if __name__ == "__main__":
    app.run()