#Exercício Python 21: Faça um programa em Python que abra e reproduza o áudio de um arquivo MP3

import pygame
import time 

pygame.init() #precisa iniciar ele 

pygame.mixer.music.load("bg3.mp3")
pygame.mixer.music.play()

time.sleep(pygame.mixer.Sound("bg3.mp3").get_length()) 

