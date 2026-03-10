# Validador de Contraseñas en C#

## Descripción
Este proyecto en **C# (Windows Forms)** permite verificar si una contraseña cumple con los requisitos mínimos de seguridad y si coincide con su confirmación.  

---

## Requisitos de seguridad
Para que una contraseña sea válida, debe cumplir con **todos** los siguientes criterios:

- Contener al menos **una letra mayúscula**.  
- Contener al menos **una letra minúscula**.  
- Contener al menos **un número**.  
- Contener al menos **un carácter especial** (`@`, `#`, `$`, `%`, `!`, `?`, `*`, etc.).  
- Coincidir exactamente con la **contraseña de confirmación**.

---

## Cómo funciona

El programa solicita dos entradas:

1. La **contraseña**.  
2. La **confirmación** de la contraseña.

Luego realiza validaciones para verificar que:

- Ambas contraseñas sean idénticas.  
<img width="504" height="388" alt="Fig1" src="https://github.com/user-attachments/assets/f43695d0-54b9-4fb7-89a0-894f737d00cf" />


- La contraseña no contiene todos los caracteres esperados.
<img width="503" height="385" alt="Fig2" src="https://github.com/user-attachments/assets/cbeebd34-be37-402a-9516-eec46c8d2f1e" />


- La contraseña cumpla con todos los criterios de seguridad.
<img width="505" height="410" alt="Fig3" src="https://github.com/user-attachments/assets/fb53c6d0-7dad-4137-9200-4260b6b14448" />






---

## Tecnologías
- **Lenguaje:** C#  
- **Plataforma:** Windows Forms  
- **Validación:** Expresiones regulares (Regex)  

---
