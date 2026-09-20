import os

from flask import Flask, render_template_string

app = Flask(__name__)

app_env = os.getenv("APP_ENV", "development")
app_message = os.getenv("APP_MESSAGE", "Hello from my Flask app!")
port = int(os.getenv("PORT", "5000"))


@app.route("/")
def home():
    return render_template_string(
        """
        <!DOCTYPE html>
        <html lang="en">
        <head>
            <meta charset="UTF-8">
            <title>Deployment Portfolio</title>
            <style>
                body {
                    font-family: Arial, sans-serif;
                    margin: 40px;
                    background-color: #f2f2f2;
                }

                .box {
                    background-color: white;
                    padding: 20px;
                    border: 1px solid #cccccc;
                    max-width: 600px;
                }
            </style>
        </head>
        <body>
            <div class="box">
                <h1>SWE40006 Deployment Portfolio</h1>
                <h2>Task 4.3 - Distinction</h2>
                <p>{{ message }}</p>
                <p>Environment: {{ environment }}</p>
            </div>
        </body>
        </html>
        """,
        message=app_message,
        environment=app_env,
    )


if __name__ == "__main__":
    app.run(host="0.0.0.0", port=port)
