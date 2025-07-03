import sys
import json
import numpy as np
from tensorflow.keras.models import load_model
from tensorflow.keras.preprocessing import image

CLASS_NAMES = ['dent', 'scratch', 'badPaint', 'clean', 'dust', 'mud']

def predict(image_path):
    model_path = r"C:\Users\abbas\OneDrive\Desktop\FYP_PROJECT\car_damage_multilabel_final.h5"
    model = load_model(model_path)
    img = image.load_img(image_path, target_size=(224, 224))
    img_array = image.img_to_array(img) / 255.0
    img_array = np.expand_dims(img_array, axis=0)

    preds = model.predict(img_array)[0]

    issues = []
    suggestions = []

    # Example suggestions per class - adjust as needed
    suggestion_map = {
        'dent': "Check for body repair",
        'scratch': "Consider repainting scratched areas",
        'badPaint': "Paint correction recommended",
        'clean': "Car is clean, no issues",
        'dust': "Car needs a thorough wash",
        'mud': "Underbody cleaning suggested"
    }

    for i, prob in enumerate(preds):
        if prob > 0.5:  # threshold, tune as you want
            issues.append(CLASS_NAMES[i])
            suggestions.append(suggestion_map.get(CLASS_NAMES[i], "Inspection needed"))

    if not issues:
        issues.append("No significant issues detected")
        suggestions.append("No action needed")

    return {
        "issue": ", ".join(issues),
        "suggestion": ", ".join(suggestions)
    }

if __name__ == "__main__":
    image_path = sys.argv[1]
    result = predict(image_path)
    print(json.dumps(result))
