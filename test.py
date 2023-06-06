import datetime
y = datetime.datetime.now().strftime("%H:%M %d:%m:%Y")
print(y)
print(type(y))
d = datetime.datetime.strptime(y,"%H:%M %d:%m:%Y")
print(d)
print(type(d))
