test = "Christmas is the 25th of December"
mydict = {
    "a":"z",
    "b":"y",
    "c":"x",
    "d":"w",
    "e":"v",
    "f":"u",
    "g":"t",
    "h":"s",
    "i":"r",
    "j":"q",
    "k":"p",
    "l":"o",
    "m":"n",
    "n":"m",
    "o":"l",
    "p":"k",
    "q":"j",
    "r":"i",
    "s":"h",
    "t":"g",
    "u":"f",
    "v":"e",
    "w":"d",
    "x":"c",
    "y":"b",
    "z":"a",
    " ": " ",
    "2":"2",
    "5":"5"}

def atbash(txt):
    txt = list(txt.lower())
    es = ""

    for x in txt:
        es = es + mydict[x]
    return(es)

atbash(test)
