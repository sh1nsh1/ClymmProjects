import telebot

tasklist = []
bot = telebot.TeleBot(open("TOKEN.txt", 'r').readline())


@bot.message_handler(commands=["start"])
def start(message):
    read_data(message)
    bot.send_message(message.chat.id, f"""Hello, {message.chat.first_name}
    I am the reminder bot. Your personal assistant, if you wish. 
    I can save your tasks, manage them.
    You can type /help to see all commands""")


@bot.message_handler(commands=["help"])
def help(message):
    read_data(message)
    bot.send_message(message.chat.id, """Commands available:
     /start - bot's introduce
     /help - see all commands
     /get - show saved task
     /add_"your task" - add new task
     /rm_(number of the task, all) - delete saved task""")


@bot.message_handler(commands=["get"])
def get_tasklist(message):
    read_data(message)
    text = show(tasklist)
    if len(tasklist) > 0:
        bot.send_message(message.chat.id, text)
    else:
        bot.send_message(message.chat.id, "No tasks")


@bot.message_handler(commands=["add"])
def add_task(message):
    read_data(message)
    tasklist.append(message.text[5:] + "\n")
    bot.send_message(message.chat.id, 'Task added')
    rewrite_data(message)


@bot.message_handler(commands=["rm"])
def remove_task(message):
    read_data(message)
    words = ['all', 'всё', 'все']
    text = message.text[4:]
    try:
        if text.isdigit():
            number = int(text)
            if 0 < number <= len(tasklist):
                tasklist.pop(number - 1)
                bot.send_message(message.chat.id, 'Task removed')
            else:
                bot.send_message(message.chat.id, 'Can not remove task')
            rewrite_data(message)
        else:
            for x in words:
                if x in text:
                    tasklist.clear()
                    bot.send_message(message.chat.id, 'All tasks removed')
                    rewrite_data(message)
    except :
        bot.send_message(message.chat.id, 'Invalid command')


def read_data(message):
    global tasklist
    tasklist = open(str(message.chat.id) + ".txt", 'r+').readlines()


def rewrite_data(message):
    open(str(message.chat.id) + '.txt', "w+").writelines("".join(tasklist))


def show(tasklist):
    line = ""
    for i in range(len(tasklist)):
        line += f"{i + 1}. {tasklist[i]}"
    return line


if __name__ == '__main__':
    bot.polling(none_stop=True, interval=0)
