
import base64
import secrets
import string
import os


class Password:

    def __init__(self, username, password_length=10) -> None:
        self.password_length = password_length
        self.username = username
        self.salt = os.urandom(256)

    def get_random_character(self, string_type=string.printable):
        return secrets.choice(string_type)

    def get_random_printable(self):
        return base64.b64encode(
            "".join(
                self.get_random_character()
                for _ in range(self.password_length)
            ).encode()
        )

    def hash_with_salt(self):
        return abs(hash(self.get_random_printable() + self.salt))


pwd = Password("alec", 10)
x = pwd.get_random_printable()
y = pwd.hash_with_salt()
z = pwd.username
print(x, y, z )
