//{
//   "ai": {
//	  "actions": {
//		 "status_text": { 
//			"chase_entity": "chasing [name(data.target)]",
//			"eat_item": "mange [name(data.target)]",
//			"fill_storage": "rempli [name(data.target)]",
//			"restock_stockpile": "range [name(data.target)]",
//			"harvest_crop": "collecte [name(data.target)]",
//			"harvest_resource": "collecte [name(data.target)]",
//			"harvest_resource_node": "collecte [name(data.target)]",
//			"light_firepit": "allume [name(data.target)]",
//			"place_item_on_structure": "place [name(data.target)]",
//			"work_at_workshop": "fabrique [str(data.craftable_name)]",
//			"attack_melee_adjacent": "attaque [name(data.target)]",
//			"resting_by_fire": "se repose prêt du feu",
//			"claiming_animal": "apprivoise un animal",
//			"looking_for_animals": "cherche des animaux",
//			"collect_ingredient": "collecte des ingrédients",
//			"build_workshop": "construit un atelier",
//			"death": "se meurt",
//			"eat": "cherche à manger",
//			"find_stray_animal": "cherche des animaux errants",
//			"harvest_field": "récolte un champs",
//			"idle": "unoccupied",
//			"patrol": "patrouille",
//			"plant_crop": "ensemence un champs",
//			"return_animals": "retourne au pâturage",
//			"combat": "engagé en combat",
//			"cower": "est tétanisé",
//			"flee": "s'enfuit",
//			"panick": "panique",
//			"mine": "mine",
//			"sleep_in_bed": "dort",
//			"sleep_on_ground": "dort par terre",
//			"check_bait_trap": "vérifie ses pièges",
//			"set_bait_trap": "fabrique des pièges",
//			"survey_trapping_grounds": "surveille ses pièges",
//			"steal_bait": "vole un appât",
//			"build_ladder": "construit une échelle",
//			"promote": "change de carrière",
//			"move_item_to_storage": "enmène un objet au stockage",
//			"teardown_ladder": "retire une échelle",
//			"drop_item_near_workshop": "retire un atelier",
//			"fabricate_structure": "construit",
//			"teardown_structure": "démolit une structure",
//			"feed_pasture_animals": "nourrit les animaux"
//		 }
//	  }
//   },
//   "ui": {
//	  "game": {
//		 "game_speed": {
//			"pause_title": "Pause",
//			"pause_description": "Met en pause le jeu",
//			"play_title": "Démarre",
//			"play_description": "Démarre le jeu à la vitesse normal",
//			"ff_title": "Jeu rapide",
//			"ff_description": "Double la vitesse du jeu",
//			"speedThree_title": "Super vitesse",
//			"speedThree_description": "Lance le jeu à haute vitesse",
//			"pause_overlay": "En pause"
//		 },
//		 "visions": {
//			"building_vision": "Vue bâtimentaire",
//			"building_vision_description": "Change la visibilité des murs, vous permettant de voir à l'intérieur des bâtiments.",
//			"terrain_slice_vision": "Vue géologique en couche",
//			"terrain_slice_vision_icon_name": "Terrain",
//			"terrain_slice_vision_description": "Découpe le terrain, vous permettant de voir les structures souterraines. Changez l'élévation pour voir différentes couches.",
//			"terrain_xray_vision_icon_name": "Rayon X",
//			"terrain_xray_vision": "Vue Rayon X",
//			"terrain_xray_vision_description": "Vue traversant les terrains. Alternez la vue complète et plate pour voir les murs souterrains."
//		 },
//		 "promotion_tree": {
//			"title": "Choisir une profession",
//			"promotion_title": "Promouvoir en [str(job_name)]", 
//			"text_1": "En l'honneur de vos efforts inébranlables et de votre rigueur, nous vous annonçons par la présente",
//			"choose": "Choisissez un hearthling...",
//			"text_2": "en ce jour du, [str(date)]",
//			"approve": "APPROUVER",
//			"approved": "APPROUVÉ",
//			"denied": "REFUSÉ! Éxigences non remplies",
//			"stamper_top_text": "CLIQUER POUR",
//			"stamper_bottom_text": "APPROUVER",
//			"requires": "Prérequis"
//		 },
//		 "build_workshop": {
//			"title": "Construire l'atelier",
//			"requirements": "Prérequis",
//			"create_stockpile": "Réserve des artisans",
//			"create_stockpile_description": "Les artisans vont stocker leur produits dans cette réserve.<p>Vous souhaiterez sans doute le placer à proximité d'une table de travail, mais bon, la décision vous reviens.",
//			"page1_subtitle2": "Cliquer sur le sol pour placer l'atelier",
//			"page2_subtitle2": "Cliquer sur le sol pour placer le stockage"
//		 },
//		 "citizen_character_sheet": {
//			"title": "Informations personnel",
//			"health": "santé",
//			"morale": "moral",
//			"experience": "expérience",
//			"max_level": "Niveau max!!!",
//			"level_text": "Niveau ",
//			"level_abbreviation": "Niv",
//			"locked_status": " (Verouillé)",
//			"apprentice": "Apprenti",
//			"journal": "Journal",
//			"attributes": "Attributs",
//			"equipment": "Équipement",
//			"abilities": "Compétences", 
//			"morale_title": "Moral",
//			"overall_morale": "Moral général",
//			"morale_food": "Nourriture", 
//			"morale_shelter": "Protection",
//			"morale_safety": "Sécurité",
//			"attack_abbreviation": "Atq",
//			"defense_abbreviation": "Déf",
//			"backpack_tab_name": "Sac à dos",
//			"journal_no_entries": "Aucune note",
//			"retired": "Mort le :"
//		 },
//		 "pet_character_sheet": {
//			"title": "Informations du famillier",
//			"release_pet_confirm_dialog": {
//			   "title": "Relâcher le famillier",
//			   "message": "Êtes-vous sûr de vouloir relâcher ce familier dans la nature ? Vous ne pourrez plus le récupérer.",
//			   "accept": "Je ne veux plus de ce famillier.",
//			   "cancel": "Attendez!"
//			},
//			"befriended_pet_description": "Est l'ami de [name(self.stonehearth:pet.owner)]"
//		 },
//		 "tutorials": {
//			"camera": {
//			   "camera_pan_title": "Pour déplacer la caméra",
//			   "camera_pan_1": "Gardez la touche espace enfoncée, et déplacez votre souris",
//			   "camera_pan_2": "Ou utilisez les touches WASD",
//			   "camera_pan_3": "Ou maintenez la molette de la souris enfoncée et déplacez la souris",
//			   "camera_orbit_title": "Pour orienter la caméra",
//			   "camera_orbit_1": "Cliquez droit et déplacez pour orienter la caméra",
//			   "camera_orbit_2": "Q et E fonctionnent aussi",
//			   "camera_zoom_title": "Pour zoomer et dézoomer",
//			   "camera_zoom_1": "Utilisez la molette de la souris",
//			   "camera_zoom_2": "Ou utilisez les touches + et - "
//			}
//		 },
//		 "save_view": {
//			"title": "Parties sauvegardées",
//			"confim_delete_title": "Confirmer la suppression",
//			"confirm_delete_message": "Voulez-vous vraiment supprimer cette sauvegarde?",
//			"confim_overwrite_title": "Confirmer le remplacement de la sauvegarde",
//			"confirm_overwrite_message": "Voulez-vous vraiment complètement, irrémédiablement remplacer cette sauvegarde?",
//			"save_autosave": "Sauvegarde automatique périodique",
//			"auto_save_prefix": "Sauvegarde automatique: ",
//			"save_in_progress": "Sauvegarde...",
//			"opt_title": "Aidez-nous à rendre Stonehearth meilleur!!",
//			"opt_text": "Voulez-vous nous permettre de recueillir des données de performance et de jeu anonymement pour nous aider à améliorer les futures versions du jeu?",
//			"opt_in_button": "Oui, Je vais aider",
//			"opt_out_button": "Nan",
//			"opt_thanks": "Merci!",
//			"save_delete": "Supprimer",
//			"save_overwrite": "Remplacer",
//			"save_new": "Nouvelle Sauvegarde",
//			"load_game": "Charger Partie",
//			"game_different_version": "Version de la sauvegarde incompatible",
//			"delete_incompatible_saves": "Supprimer les sauvegardes incomaptibles"
//		 },
//		 "common": {
//			"ok": "OK",
//			"cancel": "Annuler",
//			"yes": "Oui",
//			"no": "Non",
//			"accept": "Accepter",
//			"decline": "Refuser",
//			"next": "Suivant",
//			"hotkey": "touche : ",
//			"remove": "Retirer",
//			"input_text_tooltip": "Cliquer pour modifier"
//		 },
//		 "party": {
//			"create_party": "Créer un groupe",
//			"edit_party": "Modifier",
//			"add_party_member": "Ajouter un membre",
//			"disband_party": "Dissoudre",
//			"add_party_member_title": "Gérer la liste",
//			"done_adding_members": "Fini",
//			"add_party_member_button": "Ajouter",
//			"remove_party_member_button": "Retirer",
//			"not_in_party": "Aucun groupe attribué",
//			"party_help": "Les membres du groupe peuvent se déplacer ensembles et êtres dirigés sur le champ de bataille.",
//			"party_editor_help": "Utilisez cet écran pour ajouter des hearthiens au groupe.",
//			"attack_banner_button": "Ordre d'attaque",
//			"attack_banner_button_help": "Envois le groupe attaquer une position",
//			"defend_banner_button": "Ralliement & Ordre de Defense",
//			"defend_banner_button_help": "Envois le groupe rallier une zone quand le Mode de Defense de la Ville est activé",
//			"default_name": "Groupe No.[str(party.ord)]"
//		 },
//		 "unit_frame": {
//			"show_character_sheet": "Afficher la feuille de personnage",
//			"focus_camera": "Centrer la caméra sur cette unité"
//		 },
//		 "citizens": {
//			"title": "Hearthlings"
//		 },
//		 "create_camp": {
//			"new_game_place_banner": "Cliquez sur moi pour placer la bannière de la colonie",
//			"click_banner_tip": "Cliquez sur la baniière pour choisir l'emplacement de votre colonie",
//			"select_camp_tip": "Now click somewhere in the world",
//			"name_camp_title": "Name your settlement",
//			"name_camp_prompt": "Type a name for your settlement!"
//		 },
//		 "calendar": {
//			"months": {
//			   "1": "moiamer", 
//			   "2": "moiprofond", 
//			   "3": "moirosée", 
//			   "4": "moimouillé", 
//			   "5": "moigrand", 
//			   "6": "moidor", 
//			   "7": "moifestin", 
//			   "8": "moiguerre", 
//			   "9": "moinouveau", 
//			   "10": "moiazure", 
//			   "11": "moimaison", 
//			   "12": "moinord" 
//			},
//			"month_format": "i18n(stonehearth:ui.game.calendar.months.[str(date.month)])",
//			"date_format_long": "Jour [str(date.day)] de i18n(stonehearth:ui.game.calendar.month_format), [str(date.year)]",
//			"date_time_long_format": "Jour [str(date.day)] of i18n(stonehearth:ui.game.calendar.month_format), [str(date.year)], [str(date.time)]"
//		 },
//		 "esc_menu": {
//			"title": "Stonehearth",
//			"resume": "Reprendre",
//			"save": "Sauvegarder ou Charger une partie",
//			"settings": "Paramétres",
//			"quit_to_menu": "Retour au menu principal",
//			"exit_game": "Quitter le jeu",
//			"post_bug": "Signaler un bug",
//			"exit_confirm_dialog": {
//			   "title": "Quitter le jeu",
//			   "message": "Voullez-vous vraiment quitter le jeu? Les changements non sauvegardés seront perdus.",
//			   "yes_button": "Oui",
//			   "cancel_button": "Annuler"
//			},
//			"return_to_menu_dialog": {
//			   "title": "Retourner au menu principal",
//			   "message": "Quitter la partie et retourner au menu principal?",
//			   "yes_button": "Oui",
//			   "cancel_button": "Annuler"
//			}
//		 },
//		 "entities": {
//			"custom_name": "[str(self.unit_info.custom_name)]",
//			"unknown_name": "Inconnu",
//			"item_categories": {
//			   "food": "Nourriture",
//			   "resources": "Ressources",
//			   "furniture": "Mobilier",
//			   "armor": "Armure",
//			   "decoration": "Décoration",
//			   "construction": "Construction",
//			   "plants": "Plantes",
//			   "weapons": "Armes",
//			   "tools": "Outils",
//			   "wealth": "Fortune",
//			   "refined": "Raffiné",
//			   "uncategorized": "Non classé",
//			   "workshops" : "Ateliers",
//			   "none": "Aucune"
//			},
//			"tooltip_combat_base_damage": "Atq :",
//			"tooltip_combat_base_damage_reduction": "Déf :",
//			"death_notification": "[name(i18n_data.entity)] est mort."
//		 },
//		 "menu": {
//			"town_menu": {
//			   "display_name": "Information du village",
//			   "description": "Information générale à propos de votre village, comment se sentent vos hearthlings, et les richesses que vous avais accumulée !"
//			},
//			"citizen_manager": {
//			   "display_name": "Hearthlings",
//			   "description": "Managez vos hearthlings et changez leur professions."
//			},
//			"harvest_menu": {
//			   "display_name": "Ressource naturelle",
//			   "description": "Récupérer les ressources ou miner les sols.",
//			   "items": {
//				  "harvest": {
//					 "display_name": "Récolte",
//					 "description": "Récoltez arbres, plantes et pierres en surface du territoire",
//					 "tip_title": "Click and drag pour récolter les ressources",
//					 "tip_description": "Bouton droit pour quitter ce mode"
//				  },
//				  "mining_ui": {
//					 "display_name": "Creuser un tunnel",
//					 "description": "Creuse des tunnels et des grottes",
//					 "tip_title": "Cliquez et relachez pour creuser dans une direction",
//					 "tip_description": "Bouton droite pour sortir"
//				  },
//				  "mine_block": {
//					 "display_name": "Creuser un bloc",
//					 "description": "Creuse des blocs individuels",
//					 "tip_title": "Cliquez et relachez pour creuser dans une direction",
//					 "tip_description": "Bouton droite pour sortir"
//				  },
//				  "cancel_task": {
//					 "display_name": "Annuler une tâche",
//					 "description": "Annule les tâches sur des objets",
//					 "tip_title": "Cliquez et relachez pour retirer différentes instructions",
//					 "tip_description": "Bouton droite pour sortir de ce mode"
//				  },
//				  "clear_item": {
//					 "display_name": "Effacer",
//					 "description": "Fait disparaitre des éléments de la surface du globe",
//					 "tip_title": "Cliquez et relachez pour supprimer définitivement des éléments",
//					 "tip_description": "Bouton droite pour sortir de ce mode",
//					 "confirm_title": "Êtes-vous sur d'effacer ces élements ?",
//					 "confirm_message": "Les objets utilisables dans cette zone vont être détruit définitivement",
//					 "confirm_clear": "Oui, détruit !",
//					 "confirm_clear_no": "Non ! J'en ai besoin !"
//				  }
//			   }
//			},
//			"zone_menu": {
//			   "display_name": "Désignation des zones",
//			   "description": "Désigne les zones sur le sol pour le stockage, l'agriculture, etc...",
//			   "items": {
//				  "create_stockpile": {
//					 "display_name": "Stock",
//					 "description": "Place une zone pour stocker des ressources.",
//					 "tip_title": "Cliquez et relachez pour créer un stock",
//					 "tip_description": "Bouton droite pour sortir ce mode"
//				  },
//				  "create_farm": {
//					 "display_name": "Ferme",
//					 "description": "Place une ferme sur le sol.",
//					 "required_job_text": "Nécessite un fermier",
//					 "tip_title": "Cliquez et relachez pour créer un nouveau champs",
//					 "tip_description": "Les fermiers vont retourner la terre et semer ici"
//				  },
//				  "create_trapping_grounds": {
//					 "display_name": "Zone piégé",
//					 "description": "Place des pièges pour capturer des petites bestioles.",
//					 "required_job_text": "Nécessite un trappeur",
//					 "tip_title": "Cliquez et relachez pour une zone piégé",
//					 "tip_description": "Les trappeurs capturent des bestioles pour leur nourriture et leur ressources dans cette zone"
//				  },
//				  "create_pasture": {
//					 "display_name": "Pâturage",
//					 "description": "Le berger va mener ses animaux ici pour paître.",
//					 "required_job_text": "Nécessite un berger",
//					 "tip_title": "Cliquez et relachez pour créer un pâturage",
//					 "tip_description": "Le berger mène les animaux ici pour subvenir à leur besoin."
//				  }
//			   }
//			},
//			"build_menu": {
//			   "display_name": "Build & Design",
//			   "description": "Build structures like houses and city walls.",
//			   "items": {
//				  "building_templates": {
//					 "display_name": "Place Building",
//					 "description": "Choose to construct a building from a pre-designed template"
//				  },
//				  "custom_building": {
//					 "display_name": "Design Building",
//					 "description": "Design your own one-of-a-kind building"
//				  },
//				  "place_item": {
//					 "display_name": "Place Item",
//					 "description": "Place items like furniture and decoration",
//					 "tip_title": "Click to place this item",
//					 "tip_description": "Rotate with , and . keys"
//				  },
//				  "build_ladder": {
//					 "display_name": "Construct Ladder",
//					 "description": "Build a ladder to access hard to reach places",
//					 "tip_title": "Click on a wall to build ladders",
//					 "tip_description": "Click to manually place a ladder to access hard to reach areas.<br><br>Right click to exit"
//				  }
//			   }
//			},
//			"fight_menu": {
//			   "display_name": "Fight & Defend",
//			   "description": "Manage your combat forces",
//			   "items": {
//				  "party_manager": {
//					 "display_name": "Parties",
//					 "description": "Organize your troops into groups"
//				  },
//				  "town_defense": {
//					 "display_name": "Town Defense Mode!",
//					 "description": "Rally your hearthlings to defend the town!",
//					 "activated_title": "Town Defense Mode Activated!",
//					 "activated_text": "Your workers have stopped their jobs and are vigilantly watching for intruduers."
//				  },
//				  "loot_item": {
//					 "display_name": "Loot",
//					 "description": "Steal items from another player.",
//					 "tip_title": "Click and drag to loot items from the world",
//					 "tip_description": "Right click to exit this mode"
//				  }
//			   }
//			},
//			"bulletin_manager": {
//			   "display_name": "Bulletins",
//			   "description": "Important notifications about the world and your town"
//			},
//			"tasks_manager": {
//			   "display_name": "Manage Tasks",
//			   "description": "Do task stuff.",
//			   "remove_stockpile": "Remove Stockpile",
//			   "pause_stockpile": "Pause",
//			   "resume_stockpile": "Resume",
//			   "group": {
//				  "stockpiles": "Stockpiles",
//				  "building": "Building",
//				  "placement": "Placed Items",
//				  "maintenance": "General Maintenance",
//				  "farming": "Farming",
//				  "harvesting": "Harvesting",
//				  "mining": "Mining",
//				  "trapping": "Trapping"
//			   },
//			   "percent_full": "[str(percent)] Percent Full",
//			   "active": "active",
//			   "paused": "paused"
//			}
//		 },
//		 "bulletin": {
//			"bulletin_list_title": "Notifications",
//			"shop": {
//			   "buy_1": "Buy 1",
//			   "buy_10": "Buy 10",
//			   "sell_1": "Sell 1",
//			   "sell_10": "Sell 10",
//			   "buy_tab": "Buy",
//			   "sell_tab": "Sell",
//			   "not_enough_gold_tooltip": "Not enough gold"
//			},
//			"quest_bulletin": {
//			   "title": "New Message"
//			},
//			"level_up_bulletin": {
//			   "title": "[name(i18n_data.entity)] has Leveled Up!",
//			   "show_char_sheet": "Character Sheet"
//			},
//			"immigration_report": {
//			   "title": "Daily Update",
//			   "immigration_report_title": "Immigration Report",
//			   "population_label": "population",
//			   "next_requirements_label": "Next hearthling requirements..."
//			},
//			"collection_quest": {
//			   "pay": "Here you go!",
//			   "cancel": "I've changed my mind"
//			}
//		 },
//		 "build_mode": {
//			"tooltips": {
//			   "building_tools": "Building Tools",
//			   "voxel_tools": "Voxel Tools",
//			   "voxel_add": "Add Voxel",
//			   "voxel_paint": "Paint Voxel",
//			   "voxel_remove": "Remove Voxel",
//			   "selection": "Selection",
//			   "delete": "Delete",
//			   "undo": "Undo",
//			   "draw_slab_tool": "Slabs",
//			   "draw_floor_tool": "Foundations",
//			   "grow_floor_tool": "Floors",
//			   "grow_roof_tool": "Roofs",
//			   "draw_door_tool": "Doors",
//			   "draw_window_tool": "Windows",
//			   "grow_wall_tool": "Walls",
//			   "draw_wall_tool": "Free Standing Walls",
//			   "draw_road_tool": "Roads",
//			   "place_furniture_tool": "Furniture",
//			   "place_decoration_tool": "Decorations"
//			},
//			"overhead_tips": {
//			   "wall_segment_tip_title": "Click to place freestanding wall segments",
//			   "wall_segment_tip_description": "Hold down SHIFT while clicking to draw connected walls",
//			   "build_title_building_designer": "Building Designer",
//			   "build_floor_tip_title": "Click and drag to place floor tiles",
//			   "build_floor_tip_description": "Right click to exit",
//			   "build_slab_tip_title": "Click and drag to build a slab",
//			   "build_slab_tip_description": "Right click to exit",
//			   "erase_structure_tip_title": "Click to erase items. Click and drag to erase floor",
//			   "erase_structure_tip_description": "Right click to exit",
//			   "roof_tip_title": "Click a walled floorplan to place the roof",
//			   "roof_tip_description": "Right click to exit",
//			   "raise_walls_tip_title": "Click a floorplan to add walls",
//			   "raise_walls_tip_description": "Right click to exit",
//			   "doodad_tip_title": "Click a wall to place the door or window",
//			   "doodad_tip_description": "Right click to exit",
//			   "draw_template_title": "Click to build template",
//			   "draw_template_description": "Rotate with , and . keys",
//			   "build_road_tip_title": "Click and drag to build road",
//			   "build_road_tip_description": "Right click to exit"
//			},
//			"building_cost": {
//			   "required_item": "Required Item",
//			   "count": "Num"
//			},
//			"overview": {
//			   "title": "Building Designer - [str(building_name)]",
//			   "building_name": "Building Name",
//			   "building_cost": "Building Cost",
//			   "start_building": "Build!",
//			   "pause_building": "Pause building",
//			   "save_building_template": "Save",
//			   "finished_editing": "Finished Editing",
//			   "start_editing": "Edit"
//			},
//			"roof_shape": {
//			   "title": "Slope, Direction, & Size",
//			   "max_height": "Max Height",
//			   "rise_slope": "Rise Slope"
//			},
//			"building_templates": {
//			   "title": "Building Templates",
//			   "design_custom_building": "Design Custom Building",
//			   "template_names": {
//				  "tiny_cottage": "Tiny Cottage",
//				  "cottage_for_two": "Cottage for Two",
//				  "shared_sleeping_quarters": "Shared Sleeping Quaters",
//				  "dining_hall": "Dining Hall"
//			   },
//			   "set_template_name_title": "Template Name",
//			   "template_default_name": "My new building template",
//			   "set_template_name_prompt": "Enter a name for this template"
//			},
//			"place_item": {
//			   "title": "Place an Item"
//			},
//			"materials": {
//			   "wall": {
//				  "material": "Wall Material",
//				  "wood_resource": "Wooden Wall",
//				  "stone_resource": "Stone Wall"
//			   },
//			   "floor": {
//				  "material": "Floor Material",
//				  "wood_resource": "Wooden Floor",
//				  "stone_resource": "Stone Floor"
//			   },
//			   "roof": {
//				  "material": "Roof Material",
//				  "wood_resource": "Wooden Roof",
//				  "stone_resource": "Stone Roof"
//			   },
//			   "column": {
//				  "material": "Column Material",
//				  "wood_resource": "Wooden Column",
//				  "stone_resource": "Stone Column"
//			   },
//			   "road": {
//				  "material": "Road Material",
//				  "wood_resource": "Wooden Road",
//				  "stone_resource": "Stone Road"
//			   },
//			   "doors": {
//				  "material": "Door Material",
//				  "wood_resource": "Wooden Door",
//				  "stone_resource": "Stone Door"
//			   },
//			   "windows": {
//				  "material": "Window Material",
//				  "wood_resource": "Wooden Window",
//				  "stone_resource": "Stone Window"
//			   }
//			},
//			"start_building_confirm": {
//			   "title": "Really start building?",
//			   "message": "Once you begin building this structure it cannot be edited. Are you sure you want to build now?",
//			   "yes": "Yes, start building!",
//			   "no": "Not yet"
//			},
//			"remove_building_confirm": {
//			   "title": "Really remove this building",
//			   "message": "Are you sure you want to remove this entire building?",
//			   "keep_building": "Keep this building",
//			   "remove_building": "Remove this building"
//			}
//		 },
//		 "zones_mode": {
//			"farm": {
//			   "choose_crop": "Choose a Crop",
//			   "fallow_name": "Fallow",
//			   "fallow_description": "Plant no crop and let the soil renew itself."
//			},
//			"mining": {
//			   "help": "Mining allows you to create underground rooms and corridors. You can also discover resources while digging.",
//			   "disable": "Suspend Mining",
//			   "enable": "Resume Mining"
//			},
//			"trapping_grounds": {
//			   "help": "Trappers will place traps in a trapping grounds and will periodically check to see if anything has been caught.",
//			   "disable": "Suspend Trapping",
//			   "enable": "Resume Trapping"
//			},
//			"pasture": {
//			   "help": "Shepherds bring animals to this region and tend to their needs here.",
//			   "choose_pasture_type": "Choose Pasture Type",
//			   "sheep_pasture_name": "Sheep Pasture",
//			   "rabbit_pasture_name": "Rabbit Pen",
//			   "poyo_pasture_name": "Poyo Coop",
//			   "sheep_pasture_description": "Sheep produce wool and can be a source of meat.",
//			   "rabbit_pasture_description": "Rabbits can be a source of jerky.",
//			   "poyo_pasture_description": "Poyos produce eggs, a valuable cooking ingredient."
//			},
//			"stockpile": {
//			   "default_stockpile_name": "Stockpile No.[str(self.unit_info.custom_name)]",
//			   "contents": "Contents",
//			   "filter": "Filter",
//			   "help": "Click the icons to choose what to store in this stockpile.",
//			   "used_space": "Espace utilisé :",
//			   "filters": {
//				  "all": "All",
//				  "none": "None",
//				  "resources": "Resources",
//				  "construction": "Construction",
//				  "goods": "Tools & Goods",
//				  "gear": "Weapons & Armor",
//				  "food_and_drink": "Food & Drink",
//				  "wealth": "Wealth",
//				  "tooltip_tools": "Tools",
//				  "tooltip_wood": "wood",
//				  "tooltip_stone": "stone",
//				  "tooltip_ore": "ore",
//				  "tooltip_animal_part": "animal parts",
//				  "tooltip_plant": "plants",
//				  "tooltip_portal": "doors & windows",
//				  "tooltip_furniture": "furniture",
//				  "tooltip_defense": "defenses",
//				  "tooltip_light": "torches & lights",
//				  "tooltip_decoration": "decorations",
//				  "tooltip_refined_cloth": "thread & cloth",
//				  "tooltip_refined_animal_part": "goods produced from bits of animals",
//				  "tooltip_refined_ore": "metal bars",
//				  "tooltip_melee_weapon": "melee weapons",
//				  "tooltip_ranged_weapon": "ranged weapons",
//				  "tooltip_light_armor": "light armor",
//				  "tooltip_heavy_armor": "heavy armor",
//				  "tooltip_exotic_gear": "exotic gear",
//				  "tooltip_drink": "tasty beverages",
//				  "tooltip_gold": "gold",
//				  "tooltip_gem": "gems and trophies",
//				  "tooltip_food_containers": "food containers",
//				  "tooltip_refined": "cooked foods",
//				  "tooltip_ingredients": "raw ingredients"
//			   }
//			}
//		 },
//		 "show_workshop": {
//			"workshop_title": "Crafting Orders",
//			"placeholder": "Type to search",
//			"show_workshop_description": "Owned by [name(owner)]",
//			"unclaimed_workshop_description": "Unclaimed",
//			"workshop_entity_claimed_description": "Owned by [name(self.stonehearth:workshop.crafter)]",
//			"craft_number_left": "Craft",
//			"craft_number_right": "right now.",
//			"craft_up_to_left": "Maintain",
//			"craft_up_to_right": "in inventory.",
//			"craft_ingredients": "Ingrédients :",
//			"craft_requirements": "Eléments requis :",
//			"unlock_text": "À débloquer :",
//			"crafting_status": "fabrication en cours...",
//			"crafting_status_queued": "Dans la file",
//			"workshop_paused_status": "en pause...",
//			"workshop_remove_confirm": "Supprimer ?",
//			"workshop_open": "Ouvert !",
//			"workshop_closed": "Fermé",
//			"maintain_option_disabled": "Build a stockpile or place a crate to unlock more crafting options!",
//			"craft": "Craft!",
//			"craftable_locked": "Unlocked at Level: [str(level)]",
//			"workshop_requirement_title": "Workshop",
//			"workshop_none_required": "None required!",
//			"workshop_required": "Requires a placed ",
//			"level_requirement_title": "Level Requirement",
//			"level_requirement_none": "None Required!",
//			"level_requirement_needed": "Requires a ",
//			"level_requirement_level": " of Level ",
//			"too_many_symbol": "lots",
//			"requirements_unmet_general": "Craft Requirements Unmet!",
//			"queue_anyway": "Queue Order Anyway",
//			"recipe_tab": "Recipes",
//			"orders_tab": "Orders",
//			"missing_ingredients": "Missing ingredients: "
//		 },
//		 "town_overview": {
//			"title": "Town Overview",
//			"journal": {
//			   "default_message": "No journal entries yet!",
//			   "signature": "--[name(entry.person)]",
//			   "today": "Today",
//			   "town_log": "Town Log",
//			   "praises": "Praises",
//			   "gripes": "Gripes",
//			   "praise_empty": "Nothing praiseworthy happened today.",
//			   "gripe_empty": "Whoa. I guess nobody has anything to gripe about."
//			},
//			"networth": {
//			   "town_description": "The [str(descriptor)] [str(noun)] of [str(town_name)]",
//			   "size": {
//				  "camp": "Camp",
//				  "settlement": "Settlement",
//				  "hamlet": "Hamlet",
//				  "village": "Village",
//				  "town": "Town",
//				  "county": "County",
//				  "kingdom": "Kingdom",
//				  "empire": "Empire"
//			   },
//			   "morale_descriptor": {
//				  "0": "Wretched",
//				  "1": "Miserable",
//				  "2": "Dejected",
//				  "3": "Listless",
//				  "4": "Fair",
//				  "5": "Good",
//				  "6": "Contented",
//				  "7": "Merry",
//				  "8": "Joyous",
//				  "9": "Buoyant",
//				  "10": "Incandescent"
//			   }
//			},
//			"score": {
//			   "net_worth": "Net worth",
//			   "edibles": "Edibles",
//			   "overall_morale": "Overall Morale",
//			   "food": "Food",
//			   "shelter": "Shelter",
//			   "safety": "Safety"
//			},
//			"tab": {
//			   "town_overview": "Town Overview",
//			   "inventory": "Inventory",
//			   "journal": "Journal"
//			}
//		 }
//	  },
//	  "shell": {
//		 "loading_screen": {
//			"initial_load_map_text": "Generating World",
//			"loading_map_flavor_text": {
//			   "001": "sharpening right angles...",
//			   "002": "decompressing voxels...",
//			   "003": "synthesizing fauna...",
//			   "004": "redistubuting redistrubutables...",
//			   "005": "terracing terrain...",
//			   "006": "stocking piles...",
//			   "007": "inflating trees...",
//			   "008": "rising sun...",
//			   "009": "floating clouds...",
//			   "010": "burlying hands...",
//			   "011": "bushing berries...",
//			   "012": "confabulating childhood...",
//			   "013": "resolving determinism...",
//			   "014": "cubulating companionship...",
//			   "015": "existentializing dilemmas...",
//			   "016": "improvising morals...",
//			   "017": "splining reticulators..",
//			   "018": "diversifying gender...",
//			   "019": "homogenizing motivation...",
//			   "020": "deriving history...",
//			   "021": "indexing bugs...",
//			   "022": "compiling truth...",
//			   "023": "recollecting marbles...",
//			   "024": "effecting mass...",
//			   "025": "experiencing higher math...",
//			   "026": "proliferating flowers...",
//			   "027": "escaping realism...",
//			   "028": "positioning plushies...",
//			   "029": "regulating hairbobs..."
//			},
//			"tips": {
//			   "000": "If your workers get stuck in a mine, you can build a ladder to get them out!",
//			   "001": "Your settlers will get a better night's sleep if you provide beds for them.",
//			   "002": "Build pens around your pastures to make sure shepherded animals stay put.",
//			   "003": "Stockpiles can be changed to hold specific kinds of items.",
//			   "004": "You can farm silkweed for a steady supply of thread fiber.",
//			   "005": "A well fed town is a happy town.",
//			   "006": "Use the . and , keys to rotate an item or building before placing it.",
//			   "007": "Your hearthlings move faster on roads.",
//			   "008": "The weaver can craft new uniforms that increases the effectiveness of your workers.",
//			   "009": "Sitting during a meal helps with digestion. Build tables and chairs for your hearthlings.",
//			   "010": "Shepherds will automatically find sheep to fill a pasture.",
//			   "011": "If you want a higher net worth, try selling your items to a merchant for gold"
//			}
//		 },
//		 "new_game": {
//			"title": "Nouveau jeu",
//			"normal_game": "Jeu normal",
//			"peaceful_game": "Jeu tranquille",
//			"normal_game_description": "L'aventure démarre dans un monde plein de dangers. Votre ville subira des assauts ennemies.",
//			"peaceful_game_description": "Un mode bac à sable, où vous êtes libre de construire votre ville sans vous soucier d'un quelconque envahisseur.",
//			"temperate_biome": "Tempéré",
//			"desert_biome": "Désertique",
//			"arctic_biome": "Arctique",
//			"swamp_biome": "Marécageux",
//			"temperate_biome_description": "Type de biome par défaut, avec beaucoup de verdure",
//			"desert_biome_description": "Sec et sablonneux, avec des grosses collines et une végétation clairsemée",
//			"arctic_biome_description": "Neigeux, avec de hautes montagnes et de grands plans d'eau",
//			"swamp_biome_description": "Biome tempéré, avec des montagnes basses et beaucoup d'eau",
//			"create_game": "Créer un jeu"
//		 },
//		 "select_settlement": {
//			"title": "Cliquez sur la carte pour choisir l'emplacement de votre colonie",
//			"loading": "Chargement...",
//			"settle_at_this_location": "S'installer ici!",
//			"clear_selection": "Choisissez un autre emplacement",
//			"regenerate_map": "Générer une nouvelle carte",
//			"world_seed": "Graine du monde : ",
//			"terrain_stats": {
//			   "trees_and_plants_title": "Arbres et plantes",
//			   "trees_and_plants_description": "Le bois est la ressource principal pour la construction. Vous aurez besoin afin de construire vos bâtiments et vos objets artisanals comme les lits, les tables et les chaises.",
//			   "wildlife_title": "Vie animal",
//			   "wildlife_description": "La faune locale peut être chassé pour la nourriture et les matériaux d'artisanat.",
//			   "minerals_title": "Minéraux",
//			   "minerals_description": "Vous aurez besoin de minéraux si vous envisagez de construire des choses de pierre ou de métal."
//			},
//			"terrain_codes": {
//			   "water": "Eau",
//			   "plains_1": "Plaines",
//			   "plains_2": "Plaines",
//			   "foothills_1": "Contreforts",
//			   "foothills_2": "Contreforts",
//			   "foothills_3": "Contreforts",
//			   "mountains_1": "Montagnes",
//			   "mountains_2": "Montagnes",
//			   "mountains_3": "Montagnes",
//			   "mountains_4": "Sommet montagneux",
//			   "mountains_5": "Sommet montagneux",
//			   "mountains_6": "Sommet montagneux",
//			   "mountains_7": "Sommet montagneux",
//			   "mountains_8": "Sommet montagneux",
//			   "vegetation_0": "Pas une mauvaise herbe",
//			   "vegetation_1": "Clairsemé",
//			   "vegetation_2": "Moyenne",
//			   "vegetation_3": "Dense",
//			   "vegetation_4": "Luxuriante",
//			   "wildlife_0": "Desolé",
//			   "wildlife_1": "Rare",
//			   "wildlife_2": "Commun",
//			   "wildlife_3": "Fourni",
//			   "wildlife_4": "Abondant",
//			   "mineral_0": "Aucun",
//			   "mineral_1": "Clairsemé",
//			   "mineral_2": "Peu fréquent",
//			   "mineral_3": "Commun",
//			   "mineral_4": "Généreux"
//			}
//		 },
//		 "settings": {
//			"title": "Paramètres",
//			"graphics": "Graphismes",
//			"gameplay": "Jouabilité",
//			"card": "Affichage: ",
//			"gfx_cardinfo": "[str(gpuRenderer)] ([str(gpuDriver)])",
//			"gfx_enable_shadows": "Activer les ombres",
//			"gfx_enable_vsync": "Activer la synchronisation verticale",
//			"gfx_enable_fullscreen": "Plein écran (Redemarrage requis))",
//			"gfx_msaa": "Niveau de l'Anticrénelage",
//			"gfx_shadows": "Detail des ombres",
//			"gfx_max_lights": "Nombre maximum de lumières",
//			"gfx_drawdistance": "Distance d'affichage",
//			"gfx_enable_ssao": "Activer l'occlusion ambiente",
//			"gfx_use_high_quality": "Activer les graphismes de haute qualité",
//			"shadow_0": "Désactiver",
//			"shadow_1": "juste un peu",
//			"shadow_2": "Un peu",
//			"shadow_3": "Un peu plus",
//			"shadow_4": "Beaucoup",
//			"shadow_5": "Énormément!",
//			"aa_slider_0": "Désactiver",
//			"aa_slider_1": "Un peu",
//			"aa_slider_2": "Un peu plus",
//			"aa_slider_3": "Beaucoup",
//			"aa_slider_4": "Énormément!",
//			"sound": "Audio",
//			"background_music_volume": "Volume de la musique",
//			"effects_volume": "Volume des effets",
//			"system": "Système",
//			"force_32_bit": "* Forcer le mode 32-bit (Redémarrage requis)",
//			"force_32_bit_note": "* Forcer le mode 32-bit seulement si c'est absolument nécéssaire. Le mode 64-bit est plus rapide et supporte de plus grands villages.",
//			"enable_lua_jit": "Utiliser Lua JIT (Redémarrage requis)",
//			"send_anon_data": "Envoyer des donnees anonymes pour améliorer Stonehearth!",
//			"language_select": "Language",
//			"enable_speed_3": "Activer la vitesse x3 (Demande un rafraîchissement de l'interface)",
//			"enable_speed_3_note": "Une baisse de performances peut être rencontrée avec de grands villages en vitesse x3. Utilisez là à vos risques et périls.",
//			"difficulty": "Difficulté",
//			"difficult_description_0": "Normal",
//			"difficult_description_1": "Moyenne",
//			"difficult_description_2": "Difficile",
//			"difficult_description_3": "Extrême",
//			"default_storage_filter_none": "Désactiver les filtres de stockage par défaut"
//		 },
//		 "title_screen": {
//			"exit": "quitter",
//			"settings": "paramètres",
//			"credits": "crédits",
//			"kingdom_of": "Le royaume de",
//			"continue_game": "Continuer",
//			"new_game": "Nouveau jeu",
//			"load_game": "Charger une partie",
//			"quick_start": "Démarrage rapide",
//			"patch_notes": "Afficher les notes de mise à jour"
//		 },
//		 "embark": {
//			"title": "Préparez-vous à partir pour l'aventure",
//			"citizen_info": "Liste d'expédition",
//			"reroll_citizens": "Générer de nouveaux hearthlings",
//			"shop_title": "Magasin du voyageur",
//			"shop_gold_label": "Or",
//			"shop_sold": "VENDU!",
//			"shop_reset_button": "Réinitialiser",
//			"finished": "Enbarquer!",
//			"no_talisman_confirm_dialog": {
//			   "title": "Enbarquer",
//			   "message": "Etes-vous sûr que vous voulez embarquer sans choisir un outil de la boutique? Comme toujours, vous obtiendrez une scie de charpentier.",
//			   "accept": "Oui, à la dure!",
//			   "cancel": "Attendez!"
//			}
//		 }
//	  },
//	  "debug": {
//		 "post_bug": {
//			"title": "Filing bugs",
//			"message": "Thanks for participating in the Stonehearth Alpha! Here's how you can file a bug.",
//			"file_bug_step_1": "Go to http://discourse.stonehearth.net/c/support/active-bug",
//			"file_bug_step_2": "Check the list of active topics, and if your bug hasn't already been reported, create a new topic",
//			"file_bug_step_3": "When filing bugs, please include screenshots of the error",
//			"file_bug_step_4": "If you're reporting a crash bug, include your unique user id"
//		 }
//	  },
//	  "data": {
//		 "tooltips": {
//			"stamina": {
//			   "display_name": "Stamina",
//			   "description": "How long this hearthling can work before needing rest.",
//			   "bullet_points": {
//				  "000": "Determines sleep duration"
//			   }
//			},
//			"inventiveness": {
//			   "display_name": "Inventiveness",
//			   "description": "How good this hearthling is at creating things. Good inventors are more likely to create fine craftables.",
//			   "bullet_points": {
//				  "000": "Improves chance to craft fine items"
//			   }
//			},
//			"shelter": {
//			   "display_name": "Shelter",
//			   "description": "Make sure your hearthlings have a comfortable bed to sleep in.",
//			   "town_description": "How your citizens feel about their lodging situation. Are there beds to sleep in?"
//			},
//			"compassion": {
//			   "display_name": "Compassion",
//			   "description": "How likely this hearthling will help out a fellow villager or befriend others.",
//			   "bullet_points": {
//				  "000": "Determines maxiumum trapper pet count",
//				  "001": "Increases shepherd animal happiness"
//			   }
//			},
//			"food": {
//			   "display_name": "Food",
//			   "description": "Make sure foods of different variety and quality are available. Cooked foods are more liked than raw foods.",
//			   "town_description": "How your citizens feel about the town's food situation. Is there enough to eat? Try to obtain a variety of foods!"
//			},
//			"diligence": {
//			   "display_name": "Diligence",
//			   "description": "This hearthling's concentration. Diligent workers complete long tasks without getting distracted.",
//			   "bullet_points": {
//				  "000": "Increases crafting speed"
//			   }
//			},
//			"willpower": {
//			   "display_name": "Willpower",
//			   "description": "How likely this hearthling is to resist enemy charms."
//			},
//			"net_worth": {
//			   "display_name": "Net Worth",
//			   "description": "A score based on the value of everything in the town's inventory.",
//			   "town_description": "The gold value of everything in the town's inventory."
//			},
//			"courage": {
//			   "display_name": "Courage",
//			   "description": "How brave this hearthling is in the face of combat.",
//			   "bullet_points": {
//				  "000": "Determines chance to flee in combat"
//			   }
//			},
//			"muscle": {
//			   "display_name": "Muscle",
//			   "description": "This hearthling's brawn.",
//			   "bullet_points": {
//				  "000": "Every 10 muscle increases weapon damage by 1"
//			   }
//			},
//			"happiness": {
//			   "display_name": "Overall Moral",
//			   "description": "This hearthling's overall happiness based on food, shelter, and safety.",
//			   "town_description": "How happy your citizens are overall. Aim for a value of 10 for ultimate happiness!"
//			},
//			"speed": {
//			   "display_name": "Speed",
//			   "description": "How fast this hearthling moves."
//			},
//			"body": {
//			   "display_name": "Body",
//			   "description": "Competence at physical activities. Hearthlings with a high Body stat will move faster. Influences Muscle, Speed, Stamina."
//			},
//			"edibles": {
//			   "display_name": "Edibles",
//			   "description": "The gold value of all the food in the town's inventory.",
//			   "town_description": "The gold value of all the food in the town's inventory"
//			},
//			"mind": {
//			   "display_name": "Mind",
//			   "description": "The ability to think intelligently. A high Mind stat allows a hearthling to exceed in complex mental tasks. Influences Diligence, Curiosity, Inventiveness."
//			},
//			"curiosity": {
//			   "display_name": "Curiosity",
//			   "description": "How much this hearthling enjoys new experiences.",
//			   "bullet_points": {
//				  "000": "Improves experience gain when crafting new items"
//			   }
//			},
//			"spirit": {
//			   "display_name": "Spirit",
//			   "description": "Faith in other people. A high Spirit hearthling will easily befriend others and stand strong against enemies. Influences Courage, Willpower, Compassion."
//			},
//			"safety": {
//			   "display_name": "Safety",
//			   "description": "Protect your town from raiders and make your citizens feel safe by assigning guards.",
//			   "town_description": "How your citizens feel about the town's security. Is the town well protected or getting pillaged by goblins?"
//			}
//		 },
//		 "constants": {
//			"food_meat_raw_name": "Raw Meat",
//			"stone_resource_name": "Stone",
//			"pelt_resource_name": "Fur Pelt",
//			"cloth_resource_name": "Bolt of Cloth",
//			"wood_resource_name": "Wood Log",
//			"thread_resource_name": "Thread",
//			"leather_resource_name": "Bolt of Leather",
//			"fiber_resource_name": "Bundle of Fiber",
//			"ingot_resource_name": "Metal Ingot"
//		 }
//	  }
//   },
//   "data": {
//	  "gm": {
//		 "campaigns": {
//			"encounters": {
//			   "daily_report_encounter": {
//				  "title": "A traveller approaches your town.",
//				  "update_title": "Daily Update",
//				  "sub_title": "Immigration Report",
//				  "food_label": "Food ",
//				  "morale_label": "Morale ",
//				  "net_worth_label": "Net Worth ",
//				  "conclusion_positive": "A new settler would like to join your town!",
//				  "conclusion_negative": "The road remains empty. Maybe tomorrow!",
//				  "success_title": "[name(i18n_data.citizen)] has joined [str(i18n_data.town_name)]!",
//				  "messages": {
//					 "000": "I've heard a lot about your town!",
//					 "001": "I'd like to join your town.",
//					 "002": "You guys really look like you could use a hand!",
//					 "003": "Wow! What a town! Let me help out!"
//				  },
//				  "outcome_statement": " A [str(i18n_data.job)] would like to join [str(i18n_data.town_name)]!"
//			   }
//			},
//			"trader": {
//			   "simple_caravan_encounter": {
//				  "message": "Hello [str(i18n_data.town_name)]! I come bearing goods for trade. Would you like to give me [str(i18n_data.your_quantity)] [str(i18n_data.your_item)](s) in exchange for [str(i18n_data.my_quantity)] [str(i18n_data.my_item)](s)?",
//				  "title": "A caravan approaches!"
//			   },
//			   "starting_food_donation": {
//				  "donation_dialog_info": {
//					 "dialog_nodes": {
//						"simple_message": {
//						   "choice_000": "Thank goodness!",
//						   "bulletin_message": {
//							  "000": "Welcome to the area, folks! Goodness, you people look starved. Here's something to help:",
//							  "001": "Just celebrated Embarcation Day, eh? Buck up! You look like you'd really benefit from something tasty. How about I give you:",
//							  "002": "Embarkees! Praise Cid. Here's something to get you started.",
//							  "003": "Long journey over the mountains, eh? Well you're in a good place now. Here's a little something to get you started!",
//							  "004": "Welcome to the area, Embarkees!! Here's a gift to get you started!"
//						   },
//						   "bulletin_title": "A grizzled traveller approaches.",
//						   "dialog_title": "Mer Burlyhands"
//						}
//					 }
//				  }
//			   },
//			   "returning_trader_encounter": {
//				  "title": "A trader approaches your town.",
//				  "trade_details": "Hello [str(i18n_data.town_name)]! I'm just passing through, but I'd be willing to make a trade or two, if you're interested. If you make me [str(i18n_data.want_number)] [str(i18n_data.want_item)], I'll be back in [str(i18n_data.num_days)] days and might be able to get you [str(i18n_data.reward_number)] [str(i18n_data.reward_item)] in exchange. Sound good?",
//				  "waiting_title": "The trader will be back in [str(i18n_data.hour_counter)] hours!",
//				  "waiting_text": "The trader will be back in [str(i18n_data.hour_counter)] hours to give you [str(i18n_data.reward_number)] [str(i18n_data.reward_item)] if you have [str(i18n_data.want_number)] [str(i18n_data.want_item)] ready for him!",
//				  "return_title": "The trader returns!",
//				  "return_greetings_positive": "I'm back! It looks like you've made me the [str(i18n_data.want_number)] [str(i18n_data.want_item)] I asked for. Are you still willing to trade them to me? I'll give you [str(i18n_data.reward_number)] [str(i18n_data.reward_item)] in exchange. Still sounds good?",
//				  "return_greetings_negative": "I'm back, but it doesn't look like you've got the [str(i18n_data.want_number)] [str(i18n_data.want_item)] I asked for. That's too bad! Maybe next time!"
//			   },
//			   "food_shop": {
//				  "shop_info": {
//					 "name": "A simple food cart",
//					 "title": "A simple food cart rolls into town"
//				  }
//			   },
//			   "rugs_shop": {
//				  "shop_info": {
//					 "name": "Havaad's Fine Rugs and Garments",
//					 "title": "A simple merchant has arrived with wares to sell"
//				  }
//			   },
//			   "stonecutter_shop": {
//				  "shop_info": {
//					 "name": "Rufus Garrow's Stonecutter Shop",
//					 "title": "Rufus Garrow has arrived with wares to sell"
//				  }
//			   },
//			   "tannery_shop": {
//				  "shop_info": {
//					 "name": "Jess Vexed's Tannery and Wilderness Supplies",
//					 "title": "A rugged survivalist stops by with her wares"
//				  }
//			   },
//			   "woodcutter_shop": {
//				  "shop_info": {
//					 "name": "Norm Windriser's Woodcutter Shop",
//					 "title": "Norm Windriser has arrived with wares to sell"
//				  }
//			   }
//			},
//			"goblin_war": {
//			   "erdenes_help": {
//				  "dialog_tree_info": {
//					 "dialog_nodes": {
//						"erdene_appears": {
//						   "choice_000": "No way!",
//						   "choice_001": "Well... yes.",
//						   "bulletin_message": {
//							  "000": "Are you afraid, valiant town? Ogo so-called-chief will be here soon. For you."
//						   },
//						   "bulletin_title": "A figure with a sibilant voice appears beside your fire",
//						   "dialog_title": "???"
//						},
//						"erdenes_help": {
//						   "choice_000": "Uh... okay?",
//						   "choice_001": "Confused. Sorry.",
//						   "bulletin_message": {
//							  "000": "To borrow strength to rise means to fall when strength fails. Ogo borrows his power not from his so-called-sayer, but from the babe he stole."
//						   },
//						   "bulletin_title": "The figure tilts her head",
//						   "dialog_title": "???"
//						},
//						"erdene_description": {
//						   "choice_000": "Cool!",
//						   "choice_001": "Sounds ominous.",
//						   "bulletin_message": {
//							  "000": "Me? I am the one who watches. You. Him. For the star. For fate.",
//							  "001": "I? I am of the Red Kiln. We would have been your saviours, but your Cid parlayed hard in your stead. So now we watch. And wait for the day when your star rises.",
//							  "002": "Me! I suppose you've earned your bit. I am an ember in the forge, a spark in the air. I watch, so that I may know when it is time for the fire to engulf us all.",
//							  "003": "Me? Today, it matters not. Tomorrow, if you still live, you may call me Erdene, of the Red Kiln."
//						   },
//						   "bulletin_title": "She smiles with a glint of teeth",
//						   "dialog_title": "???"
//						},
//						"accept_offer": {
//						   "choice_000": "Wait! Who are you?",
//						   "choice_001": "Huh.",
//						   "bulletin_message": {
//							  "000": "Fight hard, little town. Fate is meaningless. But were it not, yours would be to rise."
//						   },
//						   "bulletin_title": "She nods firmly",
//						   "dialog_title": "???"
//						},
//						"flute_description": {
//						   "choice_000": "Sounds good!",
//						   "choice_001": "No. Thanks.",
//						   "bulletin_message": {
//							  "000": "Upon this paper, you shall find the lullabye to sooth the Mountain's soul. Find a stolen flute. Bid your wood-worker pitch it to this melody. Grant it to your bravest sheep-singer, set him at Ogo's great mammoth, and watch self-importance meet it's just reward."
//						   },
//						   "bulletin_title": "She offers a scrap of paper",
//						   "dialog_title": "???"
//						},
//						"departure": {
//						   "bulletin_message": {
//							  "000": "Well then. Fight hard, little town."
//						   },
//						   "bulletin_title": "She shrugs",
//						   "dialog_title": "???"
//						}
//					 }
//				  }
//			   },
//			   "ogos_bannerman": {
//				  "dialog_tree_info": {
//					 "dialog_nodes": {
//						"soothsayer_description": {
//						   "choice_000": "No way!",
//						   "choice_001": "Huh.",
//						   "bulletin_message": {
//							  "000": "Soothsayer magic! Speak with old ones! Tell future! He see... he see Red Kiln Falling, new star rising. That star is Ogo. This time, we pick winning side!",
//							  "001": "Soothsayer old, old snake. Speaks out with bones and scales. Sees future! Sees cycle ending, ending forever. Not sure what he mean, but good for Ogo!",
//							  "002": "Soothsayer goblin, obviously! Goblin who can see future! He say old ones dying away, new star rising. Good for Ogo, bad for everyone else, you included!"
//						   },
//						   "bulletin_title": "The goblin's eyes grow round",
//						   "dialog_title": "Ogo's Bannerman"
//						},
//						"snooty_introduction": {
//						   "choice_000": "Huh.",
//						   "choice_001": "Gagh!",
//						   "bulletin_message": {
//							  "000": "Ho, puny town! Me stand here with bad news for you!",
//							  "001": "Puny Town! Bow and tremble!",
//							  "002": "Muahahahahah! This? This your town? I laugh till I cry!"
//						   },
//						   "bulletin_title": "A goblin with a officious smirk slithers into town",
//						   "dialog_title": "Ogo's Bannerman"
//						},
//						"ogo_introduction": {
//						   "choice_000": "Ogo who?",
//						   "choice_001": "Uh. No.",
//						   "bulletin_message": {
//							  "000": "By order of Ogo Skullbonker, Goblin-All-Chief-To-Be, you and all your stuffs now be tribute to Great Glittering Army and Red Kiln Empire!",
//							  "001": "I envoy of Ogo Skullbonker, tamer of Mountains! Ogo demand many thing from all, include you, include your gold!",
//							  "002": "My Chief-of-Chiefs, Ogo Skullbonker, soon rule take Glittering Army and rule all of Red Kiln! You next of many conquests. You become our goldfarmers!",
//							  "003": "I am Bannergoblin of Ogo Skullbonker, rider of Mountain! My master demand you tribute, in form of all you have! You give everything! Or you pay!",
//							  "004": "I bannergoblin of Ogo Skullbonker! When you bested the small chiefs, you bring Ogo's Eye upon you! And Ogo's Eye know all! You will give tribute, or eye will see your end!"
//						   },
//						   "bulletin_title": "The goblin straightens",
//						   "dialog_title": "Ogo's Bannerman"
//						},
//						"ogo_description": {
//						   "choice_000": "Soothsayer?",
//						   "choice_001": "Eh",
//						   "bulletin_message": {
//							  "000": "Soothsayer say Ogo Skullbonker will be hero above all heroes! You destined to give him gold!",
//							  "001": "Soothsayer little, but have big thoughts! Soothsayer never wrong. Soothsayer say you give Ogo gold, or Ogo will take it from you!",
//							  "002": "Goblins long be shunned and forgotten. Soothsayer say that Ogo Skullbonker, my LittleChief, will soon change everything! For that, he need gold and labor!",
//							  "003": "Ogo Skullbonker, Master of Masters, have great destiny, to rule over all! Soothsayer say so; soothsayer never wrong. Soothsayer say, you will help!"
//						   },
//						   "bulletin_title": "The goblin's eyes glow with zeal",
//						   "dialog_title": "Ogo's Bannerman"
//						},
//						"conclusion": {
//						   "bulletin_message": {
//							  "000": "Anyway, it matter not! I here only to warn you: muster your gold, so it easy for us to collect! We be back soon!",
//							  "001": "Hahaha! Whatever. You all belong to us now. We come soon to collect you for gold mines!",
//							  "002": "Oh, you say something? No matter, we return soon! Collect all your things so will be easy for us to move!",
//							  "003": "Anyway, time to go iron my banner. Be back soon! Be ready, yes? New life under goblin rule awaits!"
//						   },
//						   "bulletin_title": "The goblin's eyes narrow",
//						   "dialog_title": "Ogo's Bannerman"
//						}
//					 }
//				  }
//			   },
//			   "moving_on_dialog": {
//				  "dialog_tree_info": {
//					 "dialog_nodes": {
//						"msg1": {
//						   "choice_000": "Thank goodness!",
//						   "choice_001": "(good riddance)",
//						   "bulletin_message": {
//							  "000": "Good news for you, pathetic humans! Ogo Skullbonker, Chief-of-Chiefs-To-Be, calls us to home for clan meet-meet. Been fun hanging with you! Maybe we tell friends, back soon for more fun taking your stuff!",
//							  "001": "Humans no challenge. So sad. We hope to return home to our Chief-of-Chiefs, Ogo Skullbonker, with story of our glory, but there is no glory in defeating you. Maybe we come back when you stronger.",
//							  "002": "We leaving now, humans. But we will be back.",
//							  "003": "Well, was fun preying on you, pathetic humans! But fun times must end, we go home now to big clan meet-meet. While we gone, build more stuff, so when we come back, we can take more!"
//						   },
//						   "bulletin_title": "The goblin sends a note",
//						   "dialog_title": "[name(i18n_data.boss)]"
//						}
//					 }
//				  }
//			   },
//			   "ogo_calls_dialog": {
//				  "dialog_tree_info": {
//					 "dialog_nodes": {
//						"loot_final": {
//						   "choice_000": "(good riddance)",
//						   "choice_001": "Goodbye!",
//						   "bulletin_message": {
//							  "000": "Hahaha! Exactly. This for you, to remember our friendship."
//						   },
//						   "bulletin_title": "The goblin places something on the ground with great care",
//						   "dialog_title": "[name(i18n_data.boss)]"
//						},
//						"information": {
//						   "choice_000": "Wow!",
//						   "choice_001": "Sounds ominous.",
//						   "bulletin_message": {
//							  "000": "You so funny. Because we friends, me tell you: Ogo pretty cool. A bit mean. Once ate a puppy. But... soothsayer say he fated! Meant to stomp on everyone! Me just little guy, you know? Though you littler. Anyways."
//						   },
//						   "bulletin_title": "The goblin laughs",
//						   "dialog_title": "[name(i18n_data.boss)]"
//						},
//						"msg1": {
//						   "choice_000": "Thank goodness!",
//						   "choice_001": "Ogo who?",
//						   "bulletin_message": {
//							  "000": "Good news peons! Ogo Skullbonker, Chief-of-Chiefs-To-Be, calls us back to him. Time to go home, show him tribute! If you lucky, maybe we be back to visit... soon!"
//						   },
//						   "bulletin_title": "The goblin returns magnanimously",
//						   "dialog_title": "[name(i18n_data.boss)]"
//						}
//					 }
//				  }
//			   },
//			   "create_wolf_riders": {
//				  "mission": {
//					 "sighted_bulletin": {
//						"title": "Snarling wolves approach!",
//						"message": "Run! Mer told you to run!!!"
//					 }
//				  }
//			   },
//			   "initial_warning": {
//				  "dialog_tree_info": {
//					 "dialog_nodes": {
//						"msg2": {
//						   "bulletin_message": {
//							  "00": "It's been pretty quiet, but you know...? It's a bad sign when the birds stop singing."
//						   },
//						   "bulletin_title": "Mer Burlyhands scratches his ear",
//						   "dialog_title": "Mer Burlyhands"
//						},
//						"msg3": {
//						   "bulletin_message": {
//							  "00": "My guess is wolves. Goblin wolves. Watch your borders. You don't want to fight them after their trainer's got them in a lather, you hear? Bunker down, if you need to. Or run. Runnin's good! No shame in surviving another day."
//						   },
//						   "bulletin_title": "Mer Burlyhands nods firmly",
//						   "dialog_title": "Mer Burlyhands"
//						},
//						"msg1": {
//						   "bulletin_message": {
//							  "00": "Ho there township! How are things for you?"
//						   },
//						   "bulletin_title": "A grizzled traveller appears on the horizon",
//						   "dialog_title": "Mer Burlyhands"
//						}
//					 }
//				  }
//			   },
//			   "mysterious_orc_hint": {
//				  "dialog_tree_info": {
//					 "dialog_nodes": {
//						"msg2": {
//						   "bulletin_message": {
//							  "000": "--the one who watches you"
//						   },
//						   "bulletin_title": "Mysterious Note",
//						   "dialog_title": "Mysterious Message"
//						},
//						"msg1": {
//						   "bulletin_message": {
//							  "000": "If you want to finish the wolves before they finish you, strike first.",
//							  "001": "There are wolves in the forest. Goblin wolves. Get them before they get you.",
//							  "002": "Ogo's forces are on the move. There are wolves in your woods.",
//							  "003": "Little human camp: search out your enemy while they yet sleep.",
//							  "004": "Goblin wolves are trained to attack on command. Free them before that command is issued, and you will sleep easy tonight."
//						   },
//						   "bulletin_title": "A message on an arrow appears on your banner",
//						   "dialog_title": "Mysterious Message"
//						}
//					 }
//				  }
//			   },
//			   "refugees_hint": {
//				  "dialog_tree_info": {
//					 "dialog_nodes": {
//						"msg1": {
//						   "bulletin_message": {
//							  "000": "There are wolves in the woods! Run away while you still can!",
//							  "001": "Can't you hear the howling? There are goblin wolves in the woods!",
//							  "002": "Our group was just attacked by goblins! Flee!",
//							  "003": "Those goblin wolves aren't like normal wolves--they're fast and viscious and unafraid! Run while you can!",
//							  "004": "You have goblins in your woods! Bunker down somewhere safe before they attack!"
//						   },
//						   "bulletin_title": "Panting refugees appear on the horizon",
//						   "dialog_title": "Refugee"
//						}
//					 }
//				  }
//			   },
//			   "temp_finish_message": {
//				  "dialog_tree_info": {
//					 "dialog_nodes": {
//						"msg2": {
//						   "bulletin_message": {
//							  "00": "Congratulations are in order, if that's the sort of thing you care about. I've been up and down the area and it seems you've taken care of the bulk of the goblins around these parts! Not saying you won't see a straggler or two come to harass you, but good job, all in all."
//						   },
//						   "bulletin_title": "Mer Burlyhands shakes his head",
//						   "dialog_title": "Mer Burlyhands"
//						},
//						"msg3": {
//						   "bulletin_message": {
//							  "00": "Here's a gift I've collected from some neighboring towns. Everyone's sleeping easier tonight because of you."
//						   },
//						   "bulletin_title": "Mer Burlyhands nods firmly",
//						   "dialog_title": "Mer Burlyhands"
//						},
//						"msg1": {
//						   "bulletin_message": {
//							  "00": "Hello there? Anyone still home?"
//						   },
//						   "bulletin_title": "Mer Burlyhands Reappears",
//						   "dialog_title": "Mer Burlyhands"
//						}
//					 }
//				  }
//			   },
//			   "wolves_escaping_dialog": {
//				  "dialog_tree_info": {
//					 "dialog_nodes": {
//						"msg1": {
//						   "bulletin_message": {
//							  "00": "Yip! Yip! AWOOOOOO!!!!!!!"
//						   },
//						   "bulletin_title": "The wolves explode joyfully from the cages",
//						   "dialog_title": "Escaping Wolves"
//						}
//					 }
//				  }
//			   },
//			   "boss_death_dialog": {
//				  "dialog_tree_info": {
//					 "dialog_nodes": {
//						"msg2": {
//						   "bulletin_message": {
//							  "00": "Tell my sheep... me loves her always..."
//						   },
//						   "bulletin_title": "[name(i18n_data.boss)] is Defeated!",
//						   "dialog_title": "[name(i18n_data.boss)]"
//						},
//						"msg3": {
//						   "bulletin_message": {
//							  "00": "You no win. Ogo... coming. Soothsayer say... Ogo... crush everyone..."
//						   },
//						   "bulletin_title": "[name(i18n_data.boss)] is Defeated!",
//						   "dialog_title": "[name(i18n_data.boss)]"
//						},
//						"msg1": {
//						   "bulletin_message": {
//							  "00": "Ow...it hurts..."
//						   },
//						   "bulletin_title": "[name(i18n_data.boss)] is Defeated!",
//						   "dialog_title": "[name(i18n_data.boss)]"
//						}
//					 }
//				  }
//			   },
//			   "goblin_raiding_camp_1": {
//				  "boss": {
//					 "display_name": "Chieftain [str(self.unit_info.custom_name)]",
//					 "description": "Me leen green fighting macheen!!!"
//				  }
//			   },
//			   "shakedown": {
//				  "collection_quest_info": {
//					 "dialog_nodes": {
//						"shakedown": {
//						   "bulletin_message": {
//							  "000": "Hahaha!! Your puny settlement now part of Glittering Territory! I deserve tribute of shinies!",
//							  "001": "Human Peons! You no understand the might of the Glittering Army! You lucky to bow before me. Also, want some things to hold to at night; to sing me to sleep. ",
//							  "002": "You got supplies? We take; we good. We have understanding?",
//							  "003": "Hahahah, you the new kid in the great Red Territory. This means me less-new-kid take your lunch. Lunch metaphor.  You make for us. Or else.",
//							  "004": "You dumb bok, me big Glittering Chieftain! Natural order mean you give me stuff and I no dees-tro-i you. Me want supplies. Understand?"
//						   },
//						   "bulletin_title": "A goblin with a fancy hat swaggers into town",
//						   "dialog_title": "[name(i18n_data.boss)]"
//						},
//						"collection_due": {
//						   "bulletin_message": {
//							  "000": "Glittering Army returns! Where iz stuff?",
//							  "001": "My stuff! Where iz?",
//							  "002": "We back. You pay tribute now. Where iz?",
//							  "003": "Me dreamed last night. In dream, you make me stuff; we like brothers only me no kill you. Got Stuff?",
//							  "004": "Want stuff now. You make? We good! You no make? You die. We all friends!"
//						   },
//						   "bulletin_title": "The goblin stomps back into town",
//						   "dialog_title": "[name(i18n_data.boss)]"
//						},
//						"collection_failed": {
//						   "bulletin_message": {
//							  "000": "You forgot stuff? You no make? You stain Glittering Army Honor! You die now!",
//							  "001": "You dumb boks no make my stuff?! Dooooom!!! DOOM TO ALL!!!",
//							  "002": "What? You no have my stuff? BLOOD, STABBITY, AND VEN-JENCE!",
//							  "003": "Me want to be good chieftan. Me want to be friends! But you no listen. No. You no worthy. Me must kill you, then go home. Cry for could-have-been. You cry too, except you dead."
//						   },
//						   "bulletin_title": "The goblin frowns so hard you can't see his eyes",
//						   "dialog_title": "[name(i18n_data.boss)]"
//						},
//						"collection_success": {
//						   "bulletin_message": {
//							  "000": "That's right. You cooperate, we get along just fine.",
//							  "001": "You actually have stuff? I never--I mean, yes. You give me due.",
//							  "002": "You got supplies? We take; we good!",
//							  "003": "For me?! You bestest of best peons!",
//							  "004": "My stuff! I take home now and cuddle to sleep at night.",
//							  "005": "Hahahahaha!!! Pretty stuff!! Beautiful stuff!! Mine mine mine!",
//							  "006": "Stuff!! Me sheep be so happy.",
//							  "007": "My stuff! Hahahah, you pretty good for peon. Be back soon!"
//						   },
//						   "bulletin_title": "The goblin grins like a kid on Frostfeast",
//						   "dialog_title": "[name(i18n_data.boss)]"
//						},
//						"collection_progress": {
//						   "bulletin_message": {
//							  "000": "Me back soon for stuff. Better have it, or no good for you, little hearthling."
//						   },
//						   "bulletin_title": "Satisfy the Goblins",
//						   "dialog_title": "[name(i18n_data.boss)]"
//						},
//						"shakedown_refused": {
//						   "bulletin_message": {
//							  "000": "What? You say no? Then we take! TAKE ALL THINGS!!!!",
//							  "001": "No no no. You supposed to say 'Yes.' You supposed to feel grateful! Try again? No? Bad! Me fix badness!",
//							  "002": "No? Me brain breaking!! Me break you!",
//							  "003": "What? Cannot believe?! Must kill!!!",
//							  "004": "You no understand. Alternative: Death. Deeeaaaattth. DEAAATTTTTHHH!!!"
//						   },
//						   "bulletin_title": "The goblin looks incredulous",
//						   "dialog_title": "[name(i18n_data.boss)]"
//						}
//					 }
//				  }
//			   },
//			   "smash_stockpiles_mission": {
//				  "missions": {
//					 "raid_stockpiles": {
//						"sighted_bulletin": {
//						   "title": "A goblin raiding party approaches!",
//						   "message": "Gonna get you!"
//						}
//					 }
//				  }
//			   },
//			   "stealthy_thief_mission": {
//				  "missions": {
//					 "raid_stockpiles": {
//						"sighted_bulletin": {
//						   "title": "A thief!",
//						   "message": "Shhhh, you're not supposed to be able to see him."
//						}
//					 }
//				  }
//			   },
//			   "steal_from_stockpiles_mission": {
//				  "missions": {
//					 "raid_stockpiles": {
//						"sighted_bulletin": {
//						   "title": "A goblin raiding party approaches!",
//						   "message": "Gonna get you!"
//						}
//					 }
//				  }
//			   }
//			},
//			"ambient_threats": {
//			   "goblin_thieves": {
//				  "missions": {
//					 "raid_stockpiles": {
//						"sighted_bulletin": {
//						   "title": "Goblin Thieves!",
//						   "message": "They yearn for comfortable things"
//						}
//					 }
//				  },
//				  "raid_stockpiles": {
//					 "thiefs": {
//						"description": "Yearns for a life of comfort"
//					 }
//				  }
//			   },
//			   "goblin_thug": {
//				  "missions": {
//					 "raid_stockpiles": {
//						"sighted_bulletin": {
//						   "title": "An armed goblin!",
//						   "message": "He wants your stuff"
//						}
//					 }
//				  },
//				  "raid_stockpiles": {
//					 "thug": {
//						"description": "Armed and dangerous!"
//					 }
//				  }
//			   },
//			   "goblin_wolf_raid": {
//				  "missions": {
//					 "raid_stockpiles": {
//						"sighted_bulletin": {
//						   "title": "A stray goblin wolf!",
//						   "message": "He wants to eat you."
//						}
//					 }
//				  },
//				  "raid_stockpiles": {
//					 "goblin_wolf": {
//						"description": "Terrifyingly ferocious"
//					 }
//				  }
//			   },
//			   "lone_thief_raid": {
//				  "missions": {
//					 "raid_stockpiles": {
//						"sighted_bulletin": {
//						   "title": "A goblin!",
//						   "message": "He wants your stuff"
//						}
//					 }
//				  },
//				  "raid_stockpiles": {
//					 "thiefs": {
//						"description": "Cowardly but covetous"
//					 },
//					 "escorts": {
//						"description": "Covetous and armed!"
//					 }
//				  }
//			   },
//			   "mauraders_raid": {
//				  "missions": {
//					 "raid_stockpiles": {
//						"sighted_bulletin": {
//						   "title": "A dangerous goblin!",
//						   "message": "He wants your stuff"
//						}
//					 }
//				  }
//			   },
//			   "spawn_night_ninjas": {
//				  "missions": {
//					 "raid_stockpiles": {
//						"sighted_bulletin": {
//						   "title": "A goblin sneaks into camp!",
//						   "message": "He's into stealth"
//						}
//					 }
//				  },
//				  "raid_stockpiles": {
//					 "thiefs": {
//						"description": "Into black pajamas."
//					 }
//				  }
//			   },
//			   "thief_with_friends": {
//				  "missions": {
//					 "raid_stockpiles": {
//						"sighted_bulletin": {
//						   "title": "A thief approaches!",
//						   "message": "He wants your stuff!!!."
//						}
//					 }
//				  },
//				  "raid_stockpiles": {
//					 "thiefs": {
//						"description": "Into black pajamas."
//					 },
//					 "goblin_wolf": {
//						"description": "Terrifyingly ferocious"
//					 }
//				  }
//			   },
//			   "undead_raid": {
//				  "mission": {
//					 "sighted_bulletin": {
//						"title": "Invaders sighted!"
//					 }
//				  }
//			   }
//			}
//		 }
//	  },
//	  "buffs": {
//		 "buff_duration_days": "[str(days)]d",
//		 "buff_duration_hours": "[str(hours)]h",
//		 "buff_duration_minutes": "[str(minutes)]m",
//		 "carrying": {
//			"carrying_buff": {
//			   "display_name": "So Heavy!",
//			   "description": "Carrying heavy things naturally causes people to move more slowly"
//			}
//		 },
//		 "combat_basics": {
//			"display_name": "Basic Combat Training",
//			"description": "Increased courage through hours of combat training"
//		 },
//		 "defender": {
//			"defender_buff": {
//			   "display_name": "Defender",
//			   "description": "Increased courage!"
//			}
//		 },
//		 "devoted": {
//			"devoted_buff": {
//			   "display_name": "Devoted",
//			   "description": "Devoted"
//			}
//		 },
//		 "groggy": {
//			"groggy_buff": {
//			   "display_name": "Groggy",
//			   "description": "A hard night's sleep on the ground lowers speed by 25%. A bed would be much better!"
//			}
//		 },
//		 "shepherding": {
//			"compassionate_shepherd_buff": {
//			   "display_name": "Cared For",
//			   "description": "Taken care of by a compassionate shepherd. This animal will produce more resources and offspring."
//			},
//			"shepherding_speed_bonus": {
//			   "display_name": "Herd Speed Increase +10%",
//			   "description": "The shepherd is now more adept at getting the flock to walk a tiny bit faster."
//			},
//			"stenched_shepherd_buff": {
//			   "display_name": "Stenched",
//			   "description": "Animals can smell that this shepherd has slaughtered something recently. This shepherd won't be able to find new wild animals until the stench fades."
//			}
//		 },
//		 "sleeping": {
//			"sleeping_buff": {
//			   "display_name": "Sleeping",
//			   "description": "Sleeping...",
//			   "short_description": "Sleeping..."
//			}
//		 },
//		 "snared": {
//			"snared_buff": {
//			   "display_name": "Snared!",
//			   "description": "Trapped by a snare and unable to move"
//			}
//		 },
//		 "starving": {
//			"starving_buff": {
//			   "display_name": "Starving",
//			   "description": "Starving hearthling needs food badly!"
//			},
//			"starving_animal_buff": {
//			   "display_name": "Starving",
//			   "description": "This animal needs food badly! It will not produce resources while starving."
//			}
//		 },
//		 "stopped": {
//			"stopped_buff": {
//			   "display_name": "Stopped",
//			   "description": "Put this buff on someone who needs to stop, right now."
//			}
//		 }
//	  },
//	  "build": {
//		 "prototypes": {
//			"building": {
//			   "display_name": "Building No.[str(self.unit_info.custom_name)]",
//			   "description": "A building.  woot!!"
//			},
//			"column": {
//			   "display_name": "Wooden Column",
//			   "description": "Provides wall support"
//			},
//			"floor": {
//			   "display_name": "Floor",
//			   "description": "Keeps feet clean"
//			},
//			"ladder": {
//			   "display_name": "Ladder",
//			   "description": "Used to reach high places"
//			},
//			"patch_wall": {
//			   "display_name": "Wall",
//			   "description": "Keeps roofs up"
//			},
//			"road": {
//			   "display_name": "Road",
//			   "description": "For speedier travel"
//			},
//			"roof": {
//			   "display_name": "Roof",
//			   "description": "Keeps the rain out"
//			},
//			"scaffolding": {
//			   "display_name": "Scaffolding",
//			   "description": "Construction support structure"
//			},
//			"wall": {
//			   "display_name": "Wall",
//			   "description": "Keeps roofs up"
//			}
//		 }
//	  },
//	  "commands": {
//		 "build_workshop": {
//			"display_name": "Build Workshop",
//			"description": "Create a place for productivity!"
//		 },
//		 "chop_tree": {
//			"display_name": "Harvest",
//			"description": "Harvest for lumber, or just to get it out of the way."
//		 },
//		 "destroy_entity": {
//			"display_name": "Destroy",
//			"description": "Irrevocably remove this item from the world!"
//		 },
//		 "harvest_berries": {
//			"display_name": "Gather Berries",
//			"description": "This bush produces berries that can be gathered to feed your settlers.",
//			"disabled_description": "The berries on this bush aren't ripe yet!"
//		 },
//		 "harvest_planted": {
//			"display_name": "Harvest",
//			"description": "Reap whatever's available."
//		 },
//		 "loot_item": {
//			"display_name": "Loot item",
//			"description": "Claim this item for your town."
//		 },
//		 "move_item": {
//			"display_name": "Move item",
//			"description": "Move this thing somewhere else in the world.",
//			"disabled_description": "This item is in use. Try moving it later."
//		 },
//		 "place_item": {
//			"display_name": "Place item",
//			"description": "Place this item in the world."
//		 },
//		 "plant_crop": {
//			"plant_corn": {
//			   "display_name": "Plant Corn!",
//			   "description": "Edible Gold."
//			},
//			"display_name": "Plant a crop!",
//			"description": "Plant something in this square.",
//			"plant_turnip": {
//			   "display_name": "Plant a Turnip!",
//			   "description": "Plant a turnip in this square."
//			}
//		 },
//		 "promote_to_job": {
//			"display_name": "Change Jobs",
//			"description": "Give this hearthling a new job."
//		 },
//		 "raze_crop": {
//			"display_name": "Clear Ground",
//			"description": "Clear or harvest the contents of this plot."
//		 },
//		 "release_pet": {
//			"display_name": "Release Pet",
//			"description": "Tell this pet you don't want it anymore."
//		 },
//		 "remove_ladder": {
//			"display_name": "Remove",
//			"description": "Remove this ladder."
//		 },
//		 "shear_sheep": {
//			"display_name": "Shear Sheep",
//			"description": "Harvest the wool from this sheep. Don't worry, it doesn't hurt...much.",
//			"disabled_description": "You'll be able to harvest this sheep again once its wool has grown back."
//		 },
//		 "show_workshop": {
//			"display_name": "Show Workshop",
//			"description": "Your crafter uses the workshop to construct useful items for your settlement.",
//			"disabled_description": "Your crafter uses the workshop to construct useful items for your settlement. Before you can craft you need to assign a crafter to this workshop."
//		 },
//		 "show_workshop_from_crafter": {
//			"display_name": "Show Workshop",
//			"description": "Your crafter uses the workshop to construct useful items for your settlement.",
//			"disabled_description": "Your crafter uses the workshop to construct useful items for your settlement. Before you can craft you need to assign a crafter to this workshop."
//		 },
//		 "slaughter": {
//			"display_name": "Harvest for Meat",
//			"description": "Harvest this animal for its meat.",
//			"disabled_description": "This animal is so malnourished that it has no meat. It's just skin and bones."
//		 },
//		 "undeploy_item": {
//			"display_name": "Undeploy",
//			"description": "Undeploy this item and return it to a stockpile",
//			"disabled_description": "This item is in use. Try undeploying it later."
//		 },
//		 "unit_control": {
//			"abilities": {
//			   "snare_trap": {
//				  "display_name": "Snare Trap",
//				  "description": "Spring a weighted net to capture small game like rabbits and squirrels."
//			   }
//			},
//			"move_unit": {
//			   "display_name": "Move",
//			   "description": "Tell this character to move somewhere else"
//			},
//			"unload_inventory": {
//			   "display_name": "Unload Bags",
//			   "description": "Return to town and desposit the contents of your bags."
//			}
//		 },
//		 "plant_tree": {
//			"display_name": "Plant Tree",
//			"description": "Plant this tree in some dirt."
//		 }
//	  },
//	  "personality": {
//		 "carpenter_promote": {
//			"promote_carpenter": {
//			   "text": "On Hearing the Call of the Saw:",
//			   "logs": {
//				  "lovable_rogue": {
//					 "000": "You want me to be the carpenter? Can I... sell the stuff I make? Or is this communal property?"
//				  },
//				  "diligent_sweetheart": {
//					 "000": "Me? You want me to be the carpenter? Ok, I'll do my best!"
//				  },
//				  "psychopathic_misanthrope": {
//					 "000": "The Saw? Where some people see a tool, I see a serrated weapon. Saw, you are my new best friend."
//				  },
//				  "insufferable_academic": {
//					 "000": "I shall endeavor to bring the music of the cubes to our furniture."
//				  },
//				  "hopeless_optimist": {
//					 "000": "Me, Carpenter? YES!! I've always wanted to make minature chairs!!!"
//				  },
//				  "beleaguered_leader": {
//					 "000": "It is my turn to wield the saw. Too bad mom always said I was bad with power."
//				  }
//			   }
//			}
//		 },
//		 "chopping_wood": {
//			"chopping_logs": {
//			   "text": "On Chopping Wood:",
//			   "logs": {
//				  "beleaguered_leader": {
//					 "000": "Today, we're chopping trees for wood. I'm already sick of the wood jokes.",
//					 "001": "Timbeerrrrr!!! I could get used to saying that.",
//					 "002": "The gang's keeping track of who's chopped down the most trees. It's me but in the time it would take to correct their math I'd rather just add another tree to my total.",
//					 "003": "Thought I saw a hornet's nest while we were logging. Luckily, everyone got out of the way in time.",
//					 "004": "Wood: our eternal taskmaster. Got to keep our eye on the goal.",
//					 "005": "Everyone chop together! Chop! Chop! Chop! Yes, hurry too!",
//					 "006": "Ok gang, breaktime's over. Back to chopping!",
//					 "007": "Every time I swing this axe, I visualize my dream house and exactly how I'm going to build it. Side effect of all this chopping: the floorplan's getting smaller.",
//					 "008": "Falling wood! Run, people! RUN!",
//					 "teacher": {
//						"000": "Attacked more trees today. By [str(entry.teacher)] there's a lot of trees out here."
//					 }
//				  },
//				  "lovable_rogue": {
//					 "000": "Step 1: Chop wood. Step 2: ???. Step 3: Profit!! Hm. Still working on step 2.",
//					 "001": "I would be more excited to chop trees if they had a discernable anatomy. Or if I could get combat advantage! Or if they could be flanked. Or if they even just had facing, so I could backstab! Not that I ever heard of anyone felling a tree with a backstab.",
//					 "002": "My hands are getting rough from all this chopping.",
//					 "003": "Top reason chopping trees is fun: perfecting the swing of the axe. May be useful one day!",
//					 "004": "Top reason carrying wood is fun: can't think of one.",
//					 "005": "I wonder how much I could sell this wood for back home. ...Nothing, probably.",
//					 "006": "I wonder if I could get out of chopping wood by pretending to have a splinter? Oh right, it woudln't be pretending.",
//					 "007": "Ow! Blister! Why am I doing this to myself? An at-will employment contract is pretty much beside the point when you're OUT IN THE MIDDLE OF NOWHERE.",
//					 "008": "Splinters! Everywhere! Ok, calming breath. Calming breath. Anyone got tweezers?"
//				  },
//				  "psychopathic_misanthrope": {
//					 "000": "Heeeaaaahhhhrrrghhh!!!",
//					 "001": "Raaaarrrrrrghhhhh!",
//					 "002": "Spork those trees, you know? Just spork them all!",
//					 "003": "I've chopped about a billion trees today. Call me axe murderer!!!",
//					 "004": "People say I have deep-seated aggression problems, but nobody complains about all the wood I produce",
//					 "005": "Is anyone else chopping these trees? It it just me?",
//					 "006": "Glad I'm doing something so physical. Sitting and knitting all day would drive me crazy."
//				  },
//				  "hopeless_optimist": {
//					 "000": "Chop chop chop! If you say it over and over, it's almost like a song!",
//					 "001": "Chopping wood builds muscles! Note to self: see if anyone's noticed.",
//					 "002": "We're sorry Mr. Tree, but we have to cut you down so we can live inside of you. But we won't ever forget that we're warm and safe thanks to your sacrifice.",
//					 "003": "There's something really satisfying about cutting down something so much bigger than me!",
//					 "004": "I'm Paul Revere! I mean, Bunyon!",
//					 "005": "How much wood would a woodchuck chuck, if a woodchuck could chuck wood? Well if my name were Woodchuck, the answer would be: lots! Note to self: find out later what a woodchuck looks like.",
//					 "006": "Lumber lumber lumber, must be lumber, in a woodman's world. Ah-aaaa, all the things I could do, if I had a little lumber, it's a woodman's worrrllld. Ahhh-AAAAAIIEEE---FALLING TREEEE!!!!!",
//					 "007": "I hear I'm not supposed to sing anymore when I'm chopping trees. Whatever!",
//					 "008": " Oh no! Mr. Squirrel! I'm so sorry. I didn't mean to cut down your house. Tell you what--move in with me! Nuts are on the house. Oh. I probably shouldn't have mentioned the house..."
//				  },
//				  "insufferable_academic": {
//					 "000": "This is an appalling underutilization of my keen mental faculties.",
//					 "001": "If I never see another axe again it will be too soon.",
//					 "002": "This might almost be worth the effort if only the lumber were destined for a paper mill.",
//					 "003": "Is there no one else who could engage in such menial labor?",
//					 "004": "I have perfected a mathematically ideal chopping motion. Alas, there are no peer-reviewed journals here in which I might publish my findings.",
//					 "005": "I cannot help but feel the necessity to mention the alarming rate at which we are deforesting the entire region... What? No, of course I'm not trying to avoid lumber duties!"
//				  },
//				  "diligent_sweetheart": {
//					 "000": "I guess I can learn to chop down trees if that's what needs to be done.",
//					 "001": "I'm going to put a little splinter beside the campfire for every tree I've cut down, separated by day. That way I can tell if I'm getting better at it!",
//					 "002": "I hope people think callouses on the palms of the hands are attractive.",
//					 "003": "I hear suffering builds character!",
//					 "004": "Chopping is kind of soothing, if you just don't worry too much about the tree falling on you.",
//					 "005": "I hope we're not disturbing anyone's home. Imagine what it would be like to have your home cut down around you to use to make someone else's home!",
//					 "006": "I hope trees don't have nerves. This would hurt a lot if they did. If they're screaming for us to stop, it must be on a different frequency.",
//					 "007": "I was holding my axe today and I realized I could do some real harm if I ever used it on a person, instead of on a tree."
//				  }
//			   }
//			}
//		 },
//		 "combat": {
//			"hurt_badly": {
//			   "text": "On Serious Injury:",
//			   "logs": {
//				  "generic": {
//					 "000": "Ow! That really hurt!",
//					 "001": "I'm in danger!",
//					 "002": "Pain!",
//					 "003": "Hurts! Must... keep going!",
//					 "004": "Things are looking bad!",
//					 "005": "Can't take much more of this!",
//					 "006": "My life's starting to flash before my eyes.",
//					 "007": "Should I be worried?",
//					 "008": "I should have written my mom more letters.",
//					 "009": "If I get out of this alive, I'm going to write Grandma and tell her I love her.",
//					 "010": "I could use some help here!",
//					 "011": "Need to keep going!!!",
//					 "012": "Raagh, take that!",
//					 "013": "If I'm going down you're coming with me!",
//					 "014": "For my friends! For my village!",
//					 "015": "I make my last stand here!"
//				  }
//			   }
//			},
//			"peaceful_day": {
//			   "text": "On Tranquility",
//			   "logs": {
//				  "generic": {
//					 "000": "Feels good to be alive!",
//					 "001": "Another awesome day in town.",
//					 "002": "Peaceful!",
//					 "003": "This seems like a pretty sheltered spot.",
//					 "004": "I was amazingly productive today!",
//					 "005": "Nothing much to do today but enjoy life!",
//					 "006": "Nature sure is beautiful!",
//					 "007": "It's great being here with friends and family.",
//					 "008": "Settling here was a great idea.",
//					 "009": "Feeling happy with a good day's work!",
//					 "010": "This really feels like a spot where we can build something great.",
//					 "011": "Uninterrupted bliss! I love days like this.",
//					 "012": "24 hours of pure tranquility.",
//					 "013": "A whole day without a single extential threat! Amazing!"
//				  }
//			   }
//			},
//			"villager_death": {
//			   "text": "On Mortality:",
//			   "logs": {
//				  "generic": {
//					 "dead_friend_and_teacher": {
//						"000": "[str(entry.teacher)] keep you safe, [name(entry.dead_friend)]."
//					 },
//					 "dead_friend": {
//						"000": "[name(entry.dead_friend)]? [name(entry.dead_friend)]!!!",
//						"001": "[name(entry.dead_friend)]? Nothing will ever be the same without you.",
//						"002": "[name(entry.dead_friend)]!!! Nooooooo!!!",
//						"003": "Goodbye, [name(entry.dead_friend)]. I hope we meet again someday.",
//						"004": "[name(entry.dead_friend)]? But... what will I tell your dad, when I next write home?",
//						"005": "We can't let [name(entry.dead_friend)]'s death be in vain, people!",
//						"006": "Goodbye, [name(entry.dead_friend)]. We'll miss you.",
//						"007": "Don't worry, [name(entry.dead_friend)]. We'll avenge you!",
//						"008": "I can't believe [name(entry.dead_friend)] is really gone.",
//						"009": "[name(entry.dead_friend)]? Gone? Suddenly this whole thing seems like it wasn't worth it, somehow.",
//						"010": "Gee, now I really wish I hadn't talked [name(entry.dead_friend)] into this adventure.",
//						"011": "[name(entry.dead_friend)]!!"
//					 }
//				  }
//			   }
//			},
//			"generic_panic": {
//			   "logs": {
//				  "diligent_sweetheart": {
//					 "000": "Oh no! Monsters!",
//					 "001": "Everyone, save yourselves!",
//					 "002": "AAAGH! MONSTERS!!!",
//					 "003": "AAAA! Please don't hurt us!!!",
//					 "004": "If I can't see it, maybe it can't see me?",
//					 "teacher": {
//						"000": "[str(entry.teacher)] SAVE US!!!"
//					 }
//				  },
//				  "insufferable_academic": {
//					 "000": "Expeditious Retreat! Expeditious Retreat!!!",
//					 "001": "When in doubt, PANIC!!!",
//					 "002": "Keep Calm and AIEEEEE!",
//					 "003": "::wails silently::",
//					 "004": "Fiends of nightmare stay away!",
//					 "005": "Terror bad for blood pressure!!!",
//					 "006": "Cardiac arrest incoming!!!",
//					 "007": "Brain... paralyzed...!",
//					 "008": "Help! Heeeeeelllpp!!!"
//				  },
//				  "belaguered_leader": {
//					 "000": "Tactical retreat! Tactical retreat!!!",
//					 "001": "Everyone make for the hills!",
//					 "002": "Drop everything and move, people!!!",
//					 "003": "They're too strong for us! Scatter, everyone!!",
//					 "004": "Run purposefully towards the exits!!!"
//				  },
//				  "generic": {
//					 "000": "Scared out of my gourd now!!!",
//					 "001": "Aauuugh!!!",
//					 "002": "Nightmare things!!!",
//					 "003": "Must run awaaaaaayyyy!!!!",
//					 "004": "::cries in terror::"
//				  },
//				  "hopeless_optimist": {
//					 "000": "Aaagh! It looks so mean!!!!",
//					 "001": "I can't see you!! I can't see you!!!",
//					 "002": "Monsters!!!!!",
//					 "003": "Auugh! Can't we just be friends??",
//					 "004": "Running away so tomorrow can be another daaaaaayyy!!!",
//					 "005": "Run, run, run away from the scary monsters!!!",
//					 "006": "I don't think it wants to be frieeendss!!!"
//				  },
//				  "psychopathic_misanthrope": {
//					 "000": "RRAAAAGGGHH!!",
//					 "001": "NEAAARRRRGHHH!",
//					 "002": "GAAAAAAAGHHH!!",
//					 "003": "AIEEEEE!!!"
//				  },
//				  "lovable_rogue": {
//					 "000": "Grab the goods and head for the hills!",
//					 "001": "Please, I don't want to die!",
//					 "002": "I have so many more things I need to do!!!!",
//					 "003": "I can't die here!!!",
//					 "004": "Must... escape!!!",
//					 "005": "Every villager for themselves!!!"
//				  }
//			   }
//			}
//		 },
//		 "dreams": {
//			"dreams": {
//			   "text": "On Dreaming:",
//			   "logs": {
//				  "insufferable_academic": {
//					 "000": "I wonder if anyone else has the dream where their clothes trail their bodies by several feet? Lucky for me, I always seem to have on my trusty pair of shiny knickers.",
//					 "001": "Last night I dreamed I stood before a class of attentive raccoons. They took notes on the nature of realtity. Afterwards, we had a stirring debate.",
//					 "002": "According to the formulae in my dreams, determinism is a myth. Time to get breakfast.",
//					 "003": "I dreamed of times present, past and future. My consciousness expanded to fill the universe. I was all, everything was me.",
//					 "004": "I dreamed I was the trees in the forest, the water in the lake, and the wind in the air.",
//					 "005": "I dreamed I was immortal, without beginning or end.",
//					 "006": "I dreamed I was between light and dark, space and time."
//				  },
//				  "lovable_rogue": {
//					 "000": "This morning, I woke up certain that wolves had stolen all the sheep. Need to build walls! Thicker walls!",
//					 "001": "I dreamed of a mine full of gold.",
//					 "002": "I had a dream where, of all things, a crocodile, stole all our food. Then he took it to a boat and stayed there",
//					 "003": "In my dream last night, I turned everything--and everyone--I touched, into gold. Oops.",
//					 "004": "I dreamed that I ate all our food supplies. Best try to avoid doing that today.",
//					 "teacher": {
//						"000": "I had the dream about fragile ladders again. I wish I knew what was at the top. I'm sure [str(entry.teacher)] is trying to tell me something."
//					 }
//				  },
//				  "hopeless_optimist": {
//					 "000": "Wolves! All night I dreamed I was being chased by wolves!",
//					 "001": "Rabbits! All night I dreamed I was being chased by rabbits!",
//					 "002": "I love dreams about flying. Tonight I flew by soft clouds and over dense trees. Watch out, birds!",
//					 "003": "I dreamed I was a goblin. Don't tell anyone, but stealing from the town was a lot of fun! (Does that make me a bad person?)",
//					 "004": "I dreamed I was cooking soup for everyone but I ran out of salt. Salt's a rock, right? Can you substitute rocks for salt? ",
//					 "005": "I dreamt a little bird alighted upon my shoulder and told me that today was going to be a great day. I can't wait!",
//					 "006": "I had a dream that in the distant future, the sons of goblins and the sons of hearthlings sat down together at the table of berries."
//				  },
//				  "diligent_sweetheart": {
//					 "000": "Whoa! I was out for a while! Do we still have all our hammers?",
//					 "001": "Oops! I must've fallen asleep! Do we still have all our trees?",
//					 "002": "I dreamed I fell asleep for a thousand years. Luckily, someone made me a shiny glass coffin with a hatch on the inside for opening. Weird.",
//					 "003": "I had a Dream where a Giant Dragon approached me! But when she opened her mouth, only kitten noises came out. Adorable!",
//					 "004": "I had a dream where I all the forest creatures and I were having a picnic, but the raccoon stole all the honey so we had nothing to put on our bread and butter.",
//					 "005": "I dreamt that everyone was jeering at me. I ran home and didn't move. Ever again.",
//					 "006": "I dreamt of a world of lush forests, and clear rivers, surrounded by friends. I woke and it was real!",
//					 "007": "I dreamt about doing all my chores. Now I've woken I have to do them all over again..."
//				  },
//				  "psychopathic_misanthrope": {
//					 "000": "Went to sleep hungry again last night and dreamed for ten consecutivie hours about poyo pot pie! Raaargh! Fear my devouring mouth!",
//					 "001": "In heaven, I hope I get a lake of poyo pot pie to swim in. Swim forever!",
//					 "002": "I dreamed about eating my fellow Hearthlings. They tasted like Poyo.",
//					 "003": "I dreamed I was a goblin. I never had to work! I just stole what I needed and started fires. That was fun!",
//					 "004": "I dreamed I was back at home, and not in the woods with THESE people..."
//				  },
//				  "generic": {
//					 "000": "First, I dreamed that I found a shiny mirror under my pillow. Then, goblins were attacking our caravan.",
//					 "001": "I dreamed I built a ladder into the sky! But then someone tore it down and left me up there. It was scary.",
//					 "002": "I dreamed that I WAS the tree being chopped down!",
//					 "003": "I dreamed about a creature with a bill of a duck and the tail of a beaver.",
//					 "004": "I dreamed that it was night time and outside of our village, there were some loud noises. Upon investigation of the fields to the south, I saw a large, black object with two circles and a bunch of dancing animals!",
//					 "005": "I dreamed my friends left me on the roof of a newly constructed building.",
//					 "006": "I dreamed I was at a lake and a luminous rabbit appeared out of the water and told me some great advice. &quot;If you build it they will come.&quot;",
//					 "007": "I dreamed my hammer was running after me",
//					 "008": "I dreamed we were racing the sheep. Something to try tomorrow?",
//					 "009": "I dreamed I couldn't stop filling my backpack with all the items littered on the ground.",
//					 "010": "Last night I had this dream where I was attacked by a swarm of poyos.",
//					 "011": "I had a dream that everyone could only collect berries. There weren't even trees to chop or blocks of stone to mine.",
//					 "012": "I dreamed I ate berries until I turned purple and then rolled away into a pond.",
//					 "013": "I dreamed that I was at the mercy of a sickness that turned me into a Zombie. The worst part: I could only walk very very slowly.",
//					 "014": "Last night I dreamed I was stranded in a hole all night and no one would build a ladder for me to climb up.",
//					 "015": "I dreamed that all the animals plotted against us and took over the town.",
//					 "016": "I dreamed that poyos rained from the sky.",
//					 "017": "I dreamed that a giant man-bunny threatened me with a spear!",
//					 "018": "I dreamed I found a mighty hammer that only I could lift.",
//					 "019": "I dreamed I was a vegetable and I planted myself so I can grow taller.",
//					 "020": "In my dream last night, I told everyone carrots made them see in the dark. This morning, we ran out of carrots. Weird!",
//					 "021": "I dreamed that I was no longer tethered to this realm, and I drifted from plane to plane.",
//					 "022": "I had a dream that people buried me and made me into a tree.",
//					 "023": "I dreamed the trees could talk.",
//					 "024": "I dreamed I spoke to a rock, but it was stone cold towards me.",
//					 "025": "I dreamed that one of the ancient trees came alive and attacked our town! It was horrible.",
//					 "026": "I dreamed about a time where houses didn't have roofs. It was very cold.",
//					 "027": "I dreamed that I walked across a vast treeless plain and all I could hear was the sounds of the wind in my ears. Bones of some large horned animal dotted the landscape. I felt so alone.",
//					 "028": "I dreamed that I could walk underwater without holding my breath.",
//					 "029": "I dreamed I was stuck in a maze. I had to run through it with the others.",
//					 "030": "I had a dream that ants were as tall as trees!",
//					 "031": "I dreamed I discovered my magical powers, and I saved my fellow Hearthlings from certain annihilation.",
//					 "032": "I dreamed I was a hero with a poyo partner. We defeat the goblins and become famous!",
//					 "033": "I dreamed of defending the town from a horde of angry farm animals.",
//					 "034": "I dreamed I met a poyo that could talk. It kept saying its name was BuckBuck.",
//					 "035": "I had a dream where I found an ancient sword in a deep crypt. When I reached out to touch it, it faded away and a mournful bell sounded. All went dark.",
//					 "036": "I had a dream that a wizard came to my door and asked me to join them on a journey! ",
//					 "037": "I had a dream that I was next in line to become a farmer.",
//					 "038": "I dreamed a giant pumpkin was rolling toward me and I couldn't move.",
//					 "039": "I dreamed about creating an apple coated with gold.",
//					 "040": "I dreamed we lived in a giant castle and I needed to clean it. I prefer to live in the woods!",
//					 "041": "I dreamed that I caught a fish the size of a titan!",
//					 "042": "I dreamed I encountered a were-sheep. It didn't end well.",
//					 "043": "I had a dream about riding a dragon. Aspirational!",
//					 "044": "I dreamed about a land that was lower than the sea yet it was still dry.",
//					 "045": "I dreamed of meeting nomads who spoke a foreign tongue. I couldn't understand a word they said.",
//					 "046": "I dreamed I had no arms.",
//					 "047": "I dreamed that I battered some poyo meat and put it in oil. Poyo nuggets they called it!",
//					 "048": "I dreamed that cloth could be a color other than blue",
//					 "049": "I had a dream where the traders were really bandits! We lost everything.",
//					 "050": "I dreamed I was being chased by a herd of stampeding mammoths.",
//					 "051": "I dreamed I was surrounded by food of all kinds, and I never had to move.",
//					 "052": "I dreamed I was the first Hearthling step onto the moon. It was a small step.",
//					 "053": "I dreamed the sheep made wonderful music, with dancing lights in the air. We partied all night.",
//					 "054": "I dreamed that the moon was smiling at us.",
//					 "055": "I dreamed that I had to catch all the critters in the land.",
//					 "056": "I dreamed about buildings as high as the sky itself.",
//					 "057": "I dreamed it was dangerous to go into the woods alone. I'd better take a sword.",
//					 "058": "I once dreamed I held a magnificent sword. Though once I firmly grasped it's handle, it turned to sand.",
//					 "059": "I dreamed I ate bread; I woke up to eat my pillow.",
//					 "060": "I dreamed I became king after pulling a sword out of a rock.",
//					 "061": "I dreamed about a man with a box who could travel in time and space. It was bigger on the inside.",
//					 "062": "I dreamed that dragons were real and we could tame them. Crazy dream!",
//					 "063": "I dreamed everywhere I went, a little goblin followed me. When I turned around to catch him he darted off into the trees.",
//					 "064": "I had a dream where there were eggs all over the ground and I had to step ever so carefully around them.",
//					 "065": "I dreamed I was eating poyo pot pie ... it tasted good.",
//					 "066": "Last night I dreamed that someone was reading my diary. Creepy.",
//					 "067": "I dreamed of creatures of immeasurable power surrounding us. They were actually poyo.",
//					 "068": "I dreamed my sword would glow blue when there were goblins nearby.",
//					 "069": "I dreamed that we fried up strips of fatty, salted meat from a tusked animal we hunted in the forest. It was the most delicious thing I ever ate! I think I'll call it ... &quot;bacon&quot;.",
//					 "070": "I dreamed I had a pretty little poyo whom I loved very much. I made it a little bonnet to wear on its head!",
//					 "071": "I had a dream in which ground shook and rumbled. The earth swallowed all our poyo.",
//					 "072": "I dreamed a squirrel chopped our house down to build its tree.",
//					 "073": "I had a dream in which a mighty warrior taught us how to shoot people in the knees with arrows.",
//					 "074": "I had a dream in which I was being baked into a giant pot pie.",
//					 "075": "I had a dream in which goblins were attacking our town, but all our weapons were replaced with corn, and our armor was made of feathers sewn together.",
//					 "076": "I had a dream in which all we could grow out of the ground were swords. We sold the swords in order to buy food.",
//					 "077": "I had a dream where I was chewing grass in the sheep pen, yet I was still a human.",
//					 "078": "I had a dream in which the dwarves were hoarding our socks.",
//					 "079": "I had a dream in which I thought I was a Poyo. I woke up outside the coop. Hm.",
//					 "080": "I had a dream that was very good, but I forgot what it was",
//					 "081": "I had that reoccurring nightmare about the berries again!",
//					 "082": "In my dream from last night, all the jerky in the stockpile became a monster. It was a jerk to everyone.",
//					 "083": "I had a dream in which I was able to make flour at a cauldron by weaving my hand together as if though I were knitting.",
//					 "084": "I had a dream in which we had to import all our corn from some far-flung and distant land.",
//					 "085": "I had a dream I was a wolf hunting Poyo's! When I awoke I had a feather in my mouth. Weird!",
//					 "086": "I had a dream about a city of gold! ",
//					 "087": "I had a dream about a magic bean that could be brewed into a potion, known as coffee, and had the ability to, seemingly, raise the dead back to life.",
//					 "088": "I had the craziest dream! There was a man, who was able to raise magma out of the earth! That's not possible, right!?",
//					 "089": "I had a dream where everything was made of paper and wood! We had to use sticks to prop ourselves up.",
//					 "090": "I had a dream in which a sheep bit me, and turned me into a sheep! But I could still talk. It was weird.",
//					 "091": "I had a dream in which I was tiny, and a portly man said he was going to &quot;Boil em, mash em, stick em in a stew!&quot; Although I awoke before anything else could happen, I assumed he was talking about me.",
//					 "092": "I dreamed about catching a giant fish! From a puddle!",
//					 "093": "I had a dream where the tree I was chopping trasformed into a giant and attacked me!",
//					 "094": "I had a dream where I was bullying a poyo and then a swarm of poyo's started attacking me! ... I am now a changed Hearthling",
//					 "095": "I had a dream, in which I was peacefully dosing off. The version of myself in that dream was also having a dream about me peacefully dosing off. This went on and on until I woke up.",
//					 "096": "I had a dream where I ate so much food I literally transformed into a planet.",
//					 "teacher": {
//						"000": "I dreamed I came upon [str(entry.teacher)] herding rabbits towards a cave.",
//						"001": "I had a dream that [str(entry.teacher)] spoke to me through a plushie toy rabbit?! I think I need to stop eating these berries."
//					 }
//				  },
//				  "beleaguered_leader": {
//					 "000": "Last night I counted sheep to get to sleep, and when I woke up, I realized that all night my dreams were about counting sheep. Joy.",
//					 "001": "I had a dream where I saw myself standing in some kind of sun-god robes on a pyramid. I had a thousand hearthlings as subjects, but they were all screaming and throwing radishes at me.",
//					 "002": "I dreamed that me and my friends lived to build a mighty empire of our own!",
//					 "003": "I dreamed that I pushed an immense boulder up a hill. When I reached the top of the hill I watched the boulder roll back down to the bottom. I then started pushing the boulder back up the hill. This happened all night long...",
//					 "004": "I had a horrible dream! I had a dream, where there were 6 other people, and we were all stuck in the- oh, wait.... that wasn't a dream.",
//					 "teacher_dreams": {
//						"000": "First, I dreamed that the trees grew arms and legs and began to sing. Then, [str(entry.teacher)] asked me to sing in front of a large audience."
//					 }
//				  }
//			   }
//			},
//			"sleep_in_bed": {
//			   "text": "On Beds:",
//			   "logs": {
//				  "generic": {
//					 "000": "It feels good to have my own bed.",
//					 "001": "Sleeping in a bed is a ton cooler than sleeping on the floor!",
//					 "002": "Beds are the best invention since regulation log sizes.",
//					 "003": "I'm never going to get tired of sleeping in a bed.",
//					 "004": "Yes! This bed is mine! M-I-N-E!",
//					 "005": "Being in my bed makes me feel so sheltered and cozy.",
//					 "006": "Home is where your bed is."
//				  }
//			   }
//			},
//			"sleep_on_ground": {
//			   "text": "On the Cold, Hard Earth:",
//			   "logs": {
//				  "generic": {
//					 "000": "Sleeping on the ground makes me super sore.",
//					 "001": "I think there was a rock in my shoulder all night.",
//					 "002": "Rattlesnakes! What if I wake up covered in rattlesnakes?!",
//					 "003": "I wish I could sleep in a real bed.",
//					 "004": "Any kind of bed would be better than sleeping on the ground",
//					 "005": "I really, really wish I had a bed to call my own.",
//					 "006": "I was too exhausted to find a proper bed, and now I'm really paying for it. Ow.",
//					 "007": "Slept on the ground again. Neck super sore. Everything looks slanted.",
//					 "008": "I counted beds to go to sleep. BEDS!",
//					 "teacher": {
//						"000": "Though [str(entry.teacher)] slept on the ground during their pilgrimage, I wish I didn't have to."
//					 }
//				  }
//			   }
//			}
//		 },
//		 "eating_berries": {
//			"eating_berries": {
//			   "text": "On Eating Berries:",
//			   "logs": {
//				  "psychopathic_misanthrope": {
//					 "000": "Huh. These berries are actually kind of growing on me. They've got that fresh, non-manured taste.",
//					 "001": "I'm not sure. These berries me feel kind of... light inside. I don't like where this is going.",
//					 "002": "Now I know why hippies are vegetarian. Screw this."
//				  },
//				  "insufferable_academic": {
//					 "000": "Dark colored berries are full of antioxidants. Which are good for you."
//				  },
//				  "hopeless_optimist": {
//					 "000": "Wow! I get to eat all the fresh berries I want! I'll never go hungry again!",
//					 "001": "I love how they make my mouth blue. And my tongue. And my insides. And--",
//					 "002": "Every berry tastes a little different. Like snowflakes, but for the mouth!",
//					 "003": "I'm getting really good at telling which berries are the crunchiest."
//				  },
//				  "beleaguered_leader": {
//					 "000": "Mmm, berries! Part of a healthy, regular diet.",
//					 "001": "Berries again! Which is good, because they're healthy for you.",
//					 "002": "Berries! They taste better than starving.",
//					 "003": "Have you eaten your berries today? I know I've eaten mine!",
//					 "004": "I wonder what's for dinner? I know--BERRIES!",
//					 "005": "Everyone's been pretty good about eating so many berries. I try to set a good example."
//				  },
//				  "lovable_rogue": {
//					 "000": "I should really stop trying to sneak these berries into my pockets. If I keep it up somebody might notice the large purple stains in my pants.",
//					 "teacher": {
//						"000": "In theory, you can ferment fruit, right? By *[str(entry.teacher)]* I miss fermented drinks."
//					 }
//				  },
//				  "diligent_sweetheart": {
//					 "000": "Mmm, berries! You never got fresh fruit in the city.",
//					 "001": "If we could just build an iron stove, I could make a pie. Well, if I also had butter. And flour. And sugar.",
//					 "002": "My figure is looking great!"
//				  }
//			   }
//			}
//		 },
//		 "eating_similar_foods": {
//			"flavor_fatigue": {
//			   "text": "On Eating the Same Thing Repeatedly:",
//			   "logs": {
//				  "generic": {
//					 "000": "Another [str(entry.recent_food)]? Joy.",
//					 "001": "If I eat one more [str(entry.recent_food)] I might throw up.",
//					 "002": "Wish I had something else to eat other than this [str(entry.recent_food)]."
//				  },
//				  "insufferable_academic": {
//					 "000": "[str(entry.recent_food)] again? If only people could be nourished by knowledge alone.",
//					 "001": "A surprising amount of digestion does not seem to happen on a one-food diet."
//				  },
//				  "beleaguered_leader": {
//					 "000": "Another [str(entry.recent_food)]? Joy.",
//					 "001": "Better chug this [str(entry.recent_food)] down; got to set a good example.",
//					 "002": "[str(entry.recent_food)] definitely tastes better than starving, but...",
//					 "003": "[str(entry.recent_food)] again? I can feel the revolt coming."
//				  },
//				  "psychopathic_misanthrope": {
//					 "000": "There's nothing to eat but [str(entry.recent_food)]? 10 days till I kill someone for their meat.",
//					 "001": "I've eaten so much of this food I can taste it in my sleep.",
//					 "002": "If I have to eat one more [str(entry.recent_food)] I swear I will start to foam at the mouth."
//				  },
//				  "diligent_sweetheart": {
//					 "000": "More [str(entry.recent_food)]? Maybe we can dry some of it to eat later?",
//					 "001": "I don't mean to complain, but all I've eaten recently is food like this [str(entry.recent_food)]. It's starting to hurt my mouth.",
//					 "002": "[str(entry.recent_food)]! Must... keep... chewing....!"
//				  },
//				  "hopeless_optimist": {
//					 "000": "Maybe if I eat enough of this food, I'll turn into it!",
//					 "001": "[str(entry.recent_food)] again? My jaws hurt.",
//					 "002": "It's okay, tongue! Just pretend you can't taste the [str(entry.recent_food)]."
//				  },
//				  "lovable_rogue": {
//					 "000": "[str(entry.recent_food)]. Great.",
//					 "001": "[str(entry.recent_food)]? I miss steak.",
//					 "002": "The market value for [str(entry.recent_food)] is essentially zero right now."
//				  }
//			   }
//			},
//			"different_food": {
//			   "text": "On Eating Something Different:",
//			   "logs": {
//				  "generic": {
//					 "000": "Mmm, I love diversity in my diet.",
//					 "001": "Eating [str(entry.recent_food)] was a nice change of pace.",
//					 "002": "Having different things at mealtimes really synergizes the flavors!",
//					 "003": "[str(entry.recent_food)] tastes better when I haven't had it for a while.",
//					 "teacher": {
//						"000": "Praise [str(entry.teacher)]! Diversity in food makes me happy."
//					 }
//				  }
//			   }
//			},
//			"super_nutritious_food": {
//			   "text": "On Eating Really Healthy:",
//			   "logs": {
//				  "lovable_rogue": {
//					 "000": "Wow, who knew [str(entry.recent_food)] was so incredibly slimming?",
//					 "001": "This [str(entry.recent_food)] is the best thing I've eaten in a long time.",
//					 "002": "I bet there's a market for food this good. Unless I should keep it all to myself?",
//					 "teacher": {
//						"000": "This was an amazing [str(entry.recent_food)]. Praise [str(entry.teacher)] and the Church of Plenty!"
//					 }
//				  },
//				  "hopeless_optimist": {
//					 "000": "Wow! I feel great!",
//					 "001": "We need to make more food like this [str(entry.recent_food)] so everyone can eat some!",
//					 "002": "Grow grow grow, grow more of this [str(entry.recent_food)]."
//				  },
//				  "beleaguered_leader": {
//					 "000": "Wow. Who'd have guessed that [str(entry.recent_food)] was a superfood?",
//					 "001": "That was a surprisngly satisfying [str(entry.recent_food)].",
//					 "002": "That [str(entry.recent_food)] was so good I should really prioritize eating more of it.",
//					 "003": "Arr! Now I feel like a superhero!"
//				  },
//				  "generic": {
//					 "000": "Wow! That [str(entry.recent_food)] made me feel super healthy!",
//					 "001": "That [str(entry.recent_food)] was surprisingly satisfying!",
//					 "002": "[str(entry.recent_food)]? Super filling!",
//					 "003": "This [str(entry.recent_food)] is going to fuel today's great works!"
//				  }
//			   }
//			}
//		 },
//		 "eat_once_per_day": {
//			"eat_once_daily": {
//			   "text": "On Eating:",
//			   "logs": {
//				  "generic": {
//					 "000": "Food! The [str(entry.recent_food)] tastes surprisingly good today.",
//					 "001": "Never really valued food like this [str(entry.recent_food)] till we moved out here.",
//					 "002": "Being fed is much, much, much cooler than being hungry.",
//					 "003": "Oh boy! [str(entry.recent_food)]. Tastes good in the tummy.",
//					 "with_reaction": {
//						"000": "Dear Diary. Today I'm eating: [str(entry.recent_food)]. Mmm!",
//						"001": "Dear Diary. Today I'm eating: [str(entry.recent_food)]. Food is good.",
//						"002": "Dear Diary. Today I'm eating: [str(entry.recent_food)]. Wooo!",
//						"003": "Dear Diary. Today I'm eating: [str(entry.recent_food)]. Happiness.",
//						"004": "Dear Diary. Today I'm eating: [str(entry.recent_food)]. Joy.",
//						"005": "Dear Diary. Today I'm eating: [str(entry.recent_food)]. Oh boy!",
//						"006": "Dear Diary. Today I'm eating: [str(entry.recent_food)]. Delicious",
//						"007": "Dear Diary. Today I'm eating: [str(entry.recent_food)]. Better than starving!"
//					 },
//					 "teacher": {
//						"000": "[str(entry.teacher)], thank you for this [str(entry.recent_food)]."
//					 }
//				  }
//			   }
//			}
//		 },
//		 "embarking": {
//			"embarking": {
//			   "text": "On Arriving:",
//			   "logs": {
//				  "insufferable_academic": {
//					 "000": "Three days have passed since I had a decent philosophical conversation. Trying not to panic. Failing. Trying to keep it in. Succeeding. Mostly."
//				  },
//				  "beleaguered_leader": {
//					 "000": "Everyone seems to have gotten here OK! Well... almost everyone..."
//				  },
//				  "diligent_sweetheart": {
//					 "000": "Wow! This is a lot of great outdoors. Well, time to form strong relationships and build community!"
//				  },
//				  "lovable_rogue": {
//					 "000": "Well, here we are, I guess. A million miles away from civilization. Great.",
//					 "001": "Mom was right. We're all going to get eaten by bears."
//				  },
//				  "hopeless_optimist": {
//					 "000": "I'm so psyched to be here, I could polka with joy!!!",
//					 "001": "I'm so psyched to be here, I could yowl with joy!!!",
//					 "002": "I'm so psyched to be here, I could cartwheel with joy!!!",
//					 "003": "I'm so psyched to be here, I could dance with joy!!!",
//					 "004": "I'm so psyched to be here, I could jump with joy!!!",
//					 "005": "I'm so psyched to be here, I could skip with joy!!!",
//					 "006": "I'm so psyched to be here, I could backflip with joy!!!"
//				  },
//				  "psychopathic_misanthrope": {
//					 "000": "At the time, wilderness seemed better than jailtime, but I'm starting to wonder.",
//					 "001": "Walk a thousand miles to get away from people and... there are still people. Spork."
//				  }
//			   }
//			}
//		 },
//		 "gathering_supplies": {
//			"gathering_supplies": {
//			   "text": "On Gathering:",
//			   "logs": {
//				  "generic": {
//					 "000": "Whoa. [str(entry.gather_target)]. Here goes!",
//					 "001": "Yup. Today I'll be gathering a [str(entry.gather_target)]! Good stuff to have on hand.",
//					 "002": "Yup. Time to get a [str(entry.gather_target)]! Here goes!",
//					 "003": "Whoa. Another [str(entry.gather_target)]! Yaaay?",
//					 "004": "Uh huh. [str(entry.gather_target)].  ",
//					 "005": "Uh huh. Another [str(entry.gather_target)]!  ",
//					 "006": "Whoa. Today I'll be gathering a [str(entry.gather_target)]! I guess I'll try not to make a mess.",
//					 "007": "Ok! Another [str(entry.gather_target)]! I guess I'll try not to make a mess.",
//					 "008": "Ok! Time to get a [str(entry.gather_target)]! Here goes!",
//					 "009": "Ok! Time to get a [str(entry.gather_target)]! Here goes!",
//					 "010": "Yup. Another [str(entry.gather_target)]!  ",
//					 "011": "Uh huh. [str(entry.gather_target)]. Here goes!",
//					 "012": "Uh huh. Another [str(entry.gather_target)]!  ",
//					 "013": "Ok! Today I'll be gathering a [str(entry.gather_target)]! Here goes!",
//					 "014": "Ok! [str(entry.gather_target)]. I guess I'll try not to make a mess.",
//					 "015": "Uh huh. [str(entry.gather_target)]. Off to work!",
//					 "016": "Yup. [str(entry.gather_target)].  ",
//					 "017": "Yup. Time to get a [str(entry.gather_target)]! Off to work!",
//					 "018": "Whoa. Today I'll be gathering a [str(entry.gather_target)]! Yaaay?",
//					 "019": "Ok! [str(entry.gather_target)]. Good stuff to have on hand.",
//					 "020": "Uh huh. Today I'll be gathering a [str(entry.gather_target)]! Yaaay!",
//					 "021": "Yup. Another [str(entry.gather_target)]! Good stuff to have on hand.",
//					 "022": "Yup. Time to get a [str(entry.gather_target)]! I guess I'll try not to make a mess.",
//					 "023": "Uh huh. Today I'll be gathering a [str(entry.gather_target)]! Yaaay?",
//					 "024": "Yup. Today I'll be gathering a [str(entry.gather_target)]! Yaaay?",
//					 "025": "Uh huh. Time to get a [str(entry.gather_target)]!  ",
//					 "026": "Uh huh. Today I'll be gathering a [str(entry.gather_target)]! Off to work!",
//					 "027": "Ok! Today I'll be gathering a [str(entry.gather_target)]! Here goes!",
//					 "028": "Uh huh. Time to get a [str(entry.gather_target)]! Good stuff to have on hand.",
//					 "029": "Whoa. [str(entry.gather_target)]. Yaaay!",
//					 "030": "Uh huh. Another [str(entry.gather_target)]! I guess I'll try not to make a mess.",
//					 "031": "Ok! Today I'll be gathering a [str(entry.gather_target)]! Here goes!",
//					 "032": "Uh huh. Today I'll be gathering a [str(entry.gather_target)]! Here goes!"
//				  },
//				  "hopeless_optimist": {
//					 "000": "Oooh! [str(entry.gather_target)]. Who would't love this?",
//					 "001": "Oooh! Another [str(entry.gather_target)]! Everyone look!",
//					 "002": "Oooh! Another [str(entry.gather_target)]! Forward!",
//					 "003": "Oooh! Time to get a [str(entry.gather_target)]! Everyone look!",
//					 "004": "Oooh! Time to get a [str(entry.gather_target)]! Forward!",
//					 "005": "Oooh! Time to get a [str(entry.gather_target)]! Who would't love this?",
//					 "006": "Oooh! Today I'll be gathering a [str(entry.gather_target)]! Everyone look!",
//					 "007": "Oooh! Today I'll be gathering a [str(entry.gather_target)]! Forward!",
//					 "008": "So excited!! [str(entry.gather_target)]. Who would't love this?",
//					 "009": "So excited!! Another [str(entry.gather_target)]! Everyone look!",
//					 "010": "So excited!! Another [str(entry.gather_target)]! Forward!",
//					 "011": "So excited!! Another [str(entry.gather_target)]! Who would't love this?",
//					 "012": "So excited!! Time to get a [str(entry.gather_target)]! Everyone look!",
//					 "013": "So excited!! Time to get a [str(entry.gather_target)]! Forward!",
//					 "014": "Woo!!! [str(entry.gather_target)]. Everyone look!",
//					 "015": "Woo!!! [str(entry.gather_target)]. Who would't love this?",
//					 "016": "Woo!!! Another [str(entry.gather_target)]! Forward!",
//					 "017": "Woo!!! Another [str(entry.gather_target)]! Who would't love this?",
//					 "018": "Woo!!! Time to get a [str(entry.gather_target)]! Everyone look!",
//					 "019": "Woo!!! Time to get a [str(entry.gather_target)]! Forward!",
//					 "020": "Woo!!! Today I'll be gathering a [str(entry.gather_target)]! Everyone look!",
//					 "021": "Woo!!! Today I'll be gathering a [str(entry.gather_target)]! Who would't love this?"
//				  },
//				  "beleaguered_leader": {
//					 "000": "Taking one for the team... Another [str(entry.gather_target)]! Remember: I chose to be here.",
//					 "001": "Leading the charge: [str(entry.gather_target)]. Joy.",
//					 "002": "Gear up, everyone! Another [str(entry.gather_target)]! Time to get to work!",
//					 "003": "Gear up, everyone! Another [str(entry.gather_target)]! Remember: I chose to be here.",
//					 "004": "Leading the charge: Today I'll be gathering a [str(entry.gather_target)]! Time to get to work!",
//					 "005": "Taking one for the team... Time to get a [str(entry.gather_target)]! Remember: I chose to be here.",
//					 "006": "Taking one for the team... Today I'll be gathering a [str(entry.gather_target)]! Time to get to work!",
//					 "007": "Taking one for the team... Another [str(entry.gather_target)]! Remember: I chose to be here.",
//					 "008": "Leading the charge: Another [str(entry.gather_target)]! Hi ho!",
//					 "009": "Leading the charge: Time to get a [str(entry.gather_target)]! Hi ho!",
//					 "010": "Leading the charge: Another [str(entry.gather_target)]! Joy.",
//					 "011": "Taking one for the team... Time to get a [str(entry.gather_target)]! Remember: I chose to be here.",
//					 "012": "Gear up, everyone! Today I'll be gathering a [str(entry.gather_target)]! Hi ho!",
//					 "013": "Listen up, everyone! Another [str(entry.gather_target)]! Time to get to work!",
//					 "014": "Leading the charge: Another [str(entry.gather_target)]! Time to get to work!",
//					 "015": "Leading the charge: Time to get a [str(entry.gather_target)]! Remember: I chose to be here.",
//					 "016": "Gear up, everyone! Another [str(entry.gather_target)]! Hi ho!",
//					 "017": "Gear up, everyone! Today I'll be gathering a [str(entry.gather_target)]! Time to get to work!",
//					 "018": "Taking one for the team... Another [str(entry.gather_target)]! Joy.",
//					 "019": "Gear up, everyone! Another [str(entry.gather_target)]! Hi ho!",
//					 "020": "Taking one for the team... Today I'll be gathering a [str(entry.gather_target)]! Remember: I chose to be here.",
//					 "021": "Leading the charge: Today I'll be gathering a [str(entry.gather_target)]! Joy.",
//					 "022": "Listen up, everyone! Time to get a [str(entry.gather_target)]! Joy.",
//					 "023": "Leading the charge: Time to get a [str(entry.gather_target)]! Time to get to work!",
//					 "024": "Gear up, everyone! Another [str(entry.gather_target)]! Hi ho!",
//					 "025": "Leading the charge: [str(entry.gather_target)]. Joy.",
//					 "026": "Listen up, everyone! [str(entry.gather_target)]. Joy.",
//					 "027": "Listen up, everyone! Time to get a [str(entry.gather_target)]! Joy.",
//					 "028": "Taking one for the team... Another [str(entry.gather_target)]! Joy.",
//					 "029": "Leading the charge: Today I'll be gathering a [str(entry.gather_target)]! Remember: I chose to be here.",
//					 "030": "Leading the charge: Another [str(entry.gather_target)]! Remember: I chose to be here.",
//					 "031": "Leading the charge: Time to get a [str(entry.gather_target)]! Joy.",
//					 "032": "Taking one for the team... Time to get a [str(entry.gather_target)]! Time to get to work!"
//				  }
//			   }
//			}
//		 },
//		 "no_food_all_day": {
//			"foodless": {
//			   "text": "On Having No Food:",
//			   "logs": {
//				  "insufferable_academic": {
//					 "000": "Fasting for a day merely offers an opportunity to observe the wailings of my monkey mind.",
//					 "001": "A day without food is an excellent way to sharpen the mind.",
//					 "002": "According to my research, people need to consume at least twenty four units of energy each day to mantain proper function."
//				  },
//				  "hopeless_optimist": {
//					 "000": "Wow, I went a whole 24 hours without food!",
//					 "001": "No food by midnight? Maybe I can drink moonlight.",
//					 "002": "So hungry... maybe tomorrow we'll find more berries."
//				  },
//				  "beleaguered_leader": {
//					 "000": "It's just 24 hours without food. Don't panic.",
//					 "001": "Hunger is good for discipline.",
//					 "002": "I'm going to dream about food tonight.",
//					 "003": "A whole day without food? Musn't complain; got to set a good example."
//				  },
//				  "psychopathic_misanthrope": {
//					 "000": "A whole day without food? My stomach is going to start eating itself.",
//					 "001": "Went a whole day without eating a single thing. Tomorrow, my 'friends' had better watch out.",
//					 "002": "I may not have eaten all day today, but I'm still a badass.",
//					 "003": "No food in camp today, huh? Maybe I can find something in the forest to kill tomorrow."
//				  },
//				  "generic": {
//					 "000": "A whole day without food? ::sigh::",
//					 "001": "I wish I had something to eat.",
//					 "002": "Going a who day without food makes me so, so sad."
//				  },
//				  "diligent_sweetheart": {
//					 "000": "It's okay, I don't need to eat every day.",
//					 "001": "By the precepts of the Church of Plenty, we should eat at least once a day.",
//					 "teacher": {
//						"000": "A day without food? At home we used to go a whole week for the festival of [str(entry.teacher)]!"
//					 }
//				  },
//				  "lovable_rogue": {
//					 "000": "24 hours without food? I'm sure I could find an opportunity here, if I weren't so hungry.",
//					 "001": "Nobody's eaten in a while. I could make a killing if I just had one of mom's apple pies.",
//					 "002": "Going without food for a whole day is surprisingly hard."
//				  }
//			   }
//			}
//		 },
//		 "starving": {
//			"starving": {
//			   "text": "On Starvation:",
//			   "logs": {
//				  "beleaguered_leader": {
//					 "000": "I don't know how long we can last without food.",
//					 "001": "Has anyone found any animals to eat yet?",
//					 "002": "Keep on the lookout for berry bushes, or something!",
//					 "003": "Got... to... keep... going....",
//					 "004": "I have to stop dreaming about food every night."
//				  },
//				  "psychopathic_misanthrope": {
//					 "000": "Is there anyone around here I can eat?",
//					 "001": "I need to kill something small and furry.",
//					 "002": "I hate eating moss.",
//					 "003": "Cannibalism. It's what's for dinner."
//				  },
//				  "diligent_sweetheart": {
//					 "000": "I'm so hungry... Step 1: Learn carpentry!",
//					 "001": "It's okay, I didn't really need to eat today.",
//					 "002": "I wish I could bake a cheesecake.",
//					 "003": "If we huddle around the fire at night, that's almost as good as eating, right?",
//					 "004": "I really don't want to die here.",
//					 "teacher": {
//						"000": "[str(entry.teacher)], even if I don't make it, keep my friends safe, okay?"
//					 }
//				  },
//				  "lovable_rogue": {
//					 "000": "In retrospect, I really should have hoarded those berries.",
//					 "001": "It's a pity you can't eat silver and gold.",
//					 "002": "That wood is starting to look like chocolate...",
//					 "teacher": {
//						"000": "As [str(entry.teacher)] is my witness, I will never go hungry again!"
//					 }
//				  },
//				  "insufferable_academic": {
//					 "000": "Hunger is merely a state of mind.",
//					 "001": "To be, or not to be, that is the question...",
//					 "002": "The needs of the stomach are merely a distraction from the pursuits of the mind.",
//					 "003": "Mind... over... matter!",
//					 "004": "I refuse to allow my vast intellect to succumb to base starvation!",
//					 "005": "According to my research, people need to consume at least twenty four units of energy each day to mantain proper function."
//				  },
//				  "hopeless_optimist": {
//					 "000": "Oh, great! Another day without food... That's exactly that little push I needed for starting my diet!",
//					 "001": "Hunger really sharpens the colors in the world!",
//					 "002": "I think there's a hole in my stomach.",
//					 "003": "Am I invisible yet?"
//				  },
//				  "generic": {
//					 "000": "I'm so hungry it hurts.",
//					 "001": "If I could just get some food, maybe my stomach would feel better.",
//					 "002": "I don't know how much longer I can go without food."
//				  }
//			   }
//			}
//		 },
//		 "weaver_promote": {
//			"promote_weaver": {
//			   "text": "On Spindles:",
//			   "logs": {
//				  "psychopathic_misanthrope": {
//					 "000": "You want me to be the weaver? Everything I know about weaving: jab the pointy end into the other person. This should be interesting."
//				  },
//				  "hopeless_optimist": {
//					 "000": "Woo! Now that I'm the weaver, I live to make comfy beds for everyone!"
//				  },
//				  "insufferable_academic": {
//					 "000": "There is a meditative grace in fine knotwork. Stare, my friends, stare until your souls belong to meeeeee."
//				  },
//				  "beleaguered_leader": {
//					 "000": "I don't know... I always expected a more epic role in life. Well, this will probably be good for my blood pressure."
//				  },
//				  "lovable_rogue": {
//					 "000": "Hmm... if a spider is a weaver, is a weaver like a spider? Everyone shall sleep safe in my webs. ...Was that too creepy?"
//				  },
//				  "diligent_sweetheart": {
//					 "000": "Oh! First thing's first--time to make everyone a new winter scarf!"
//				  }
//			   }
//			}
//		 }
//	  }
//   },
//   "entities": {
//	  "armor": {
//		 "basic_shield": {
//			"display_name": "Bouclier fidèle",
//			"description": "Armure portative !",
//			"basic_shield_iconic": {
//			   "display_name": "Bouclier fidèle",
//			   "description": "Armure portative !"
//			}
//		 },
//		 "iron_shield": {
//			"display_name": "Bouclier lourd en fer",
//			"description": "Ouuf. Lourd.",
//			"iron_shield_iconic": {
//			   "display_name": "Bouclier lourd en fer",
//			   "description": "Ouuf. Lourd."
//			}
//		 },
//		 "bronze_breastplate": {
//			"display_name": "Plastron en bronze",
//			"description": "Armure",
//			"bronze_breastplate_iconic": {
//			   "display_name": "Plastron en bronze",
//			   "description": "Armure"
//			}
//		 },
//		 "cloth_padded_vest": {
//			"display_name": "Gilet rembourré",
//			"description": "Procure une légére protection en combat.",
//			"cloth_padded_vest_iconic": {
//			   "display_name": "Gilet rembourrè",
//			   "description": "Procure une légére protection en combat. Chaque petit geste compte!"
//			}
//		 },
//		 "iron_mail": {
//			"display_name": "Cuirasse en fer",
//			"description": "Une armure complète en fer",
//			"iron_mail_iconic": {
//			   "display_name": "Cuirasse en fer",
//			   "description": "Une armure complète en fer"
//			}
//		 },
//		 "leather_vest": {
//			"display_name": "Gilet de cuir épais",
//			"description": "Le cuir durci offre une meilleur protection.",
//			"leather_vest_iconic": {
//			   "display_name": "Gilet de cuir épais",
//			   "description": "Le cuir durci offre une meilleur protection."
//			}
//		 },
//		 "steel_mail": {
//			"display_name": "Armure de plates",
//			"description": "Une armure complète en acier",
//			"steel_mail_iconic": {
//			   "display_name": "Armure de plates",
//			   "description": "Une armure complète en acier"
//			}
//		 },
//		 "studded_leather_helmet": {
//			"display_name": "Casque clouté en cuir",
//			"description": "Protège votre tête"
//		 },
//		 "wooden_shield": {
//			"display_name": "Bouclier en bois brut",
//			"description": "Brut et basique",
//			"wooden_shield_iconic": {
//			   "display_name": "Bouclier en bois brut",
//			   "description": "Brut et basique"
//			}
//		 }
//	  },
//	  "boulders": {
//		 "large_boulder": {
//			"large_boulder_1": {
//			   "display_name": "Énorme rocher",
//			   "description": "Exploitable pour de la pierre"
//			},
//			"large_boulder_2": {
//			   "display_name": "Énorme rocher",
//			   "description": "Exploitable pour de la pierre"
//			}
//		 },
//		 "medium_boulder": {
//			"medium_boulder_1": {
//			   "display_name": "Rocher moyen",
//			   "description": "Exploitable pour de la pierre"
//			},
//			"medium_boulder_2": {
//			   "display_name": "Rocher moyen",
//			   "description": "Exploitable pour de la pierre"
//			},
//			"medium_boulder_3": {
//			   "display_name": "Rocher moyen",
//			   "description": "Exploitable pour de la pierre"
//			}
//		 },
//		 "small_boulder": {
//			"display_name": "Petit rocher",
//			"description": "Exploitable pour de la pierre"
//		 }
//	  },
//	  "construction": {
//		 "cobblestone_fence": {
//			"cobblestone_fence_ghost": {
//			   "display_name": "Clôture en pierre",
//			   "description": "Un rustique, mais solide segment de mur."
//			}
//		 },
//		 "cobblestone_fence_gate": {
//			"cobblestone_fence_gate_ghost": {
//			   "display_name": "Portail de clôture en pierre",
//			   "description": "Ces épais murs de pierre confèrent un sentiment de sécurité."
//			}
//		 },
//		 "crafting": {
//			"workshop_outbox": {
//			   "display_name": "Boîte de produit fini",
//			   "description": "Stocke les fabrications terminées"
//			}
//		 },
//		 "picket_fence": {
//			"picket_fence_ghost": {
//			   "display_name": "Palissade",
//			   "description": "Si elle n'est pas blanche, c'est que notre vie est incomplète?"
//			}
//		 },
//		 "picket_fence_gate": {
//			"picket_fence_gate_ghost": {
//			   "display_name": "Portail de palissade",
//			   "description": "VOus n'aimez pas vos voisins? Ne pas installer."
//			}
//		 },
//		 "stockpile": {
//			"display_name": "Réserve",
//			"description": "Pour stocker des choses"
//		 },
//		 "wooden_diamond_window": {
//			"wooden_diamond_window_ghost": {
//			   "display_name": "Cardre de fenêtre diamant",
//			   "description": "Tant pis pour la vie privée..."
//			}
//		 },
//		 "wooden_door": {
//			"wooden_door_ghost": {
//			   "display_name": "Porte en bois",
//			   "description": "Enfin un peu de vide privée !"
//			}
//		 },
//		 "wooden_door_2": {
//			"wooden_door_2_ghost": {
//			   "display_name": "Porte en bois renforcée",
//			   "description": "Plus robuste que votre porte classique."
//			}
//		 },
//		 "wooden_door_4x4": {
//			"wooden_door_ghost": {
//			   "display_name": "Porte en bois",
//			   "description": "Enfin un peu de vide privée !"
//			}
//		 },
//		 "wooden_double_door": {
//			"wooden_double_door_ghost": {
//			   "display_name": "Double porte en bois",
//			   "description": "Une grande porte. Ça fait forte impression."
//			}
//		 },
//		 "wooden_window_frame": {
//			"wooden_window_frame_ghost": {
//			   "display_name": "Cadre de fenêtre en bois",
//			   "description": "Tant pis pour la vie privée..."
//			}
//		 }
//	  },
//	  "containers": {
//		 "large_crate": {
//			"large_crate_ghost": {
//			   "display_name": "Grande caisse",
//			   "description": "Boîte de rangement."
//			}
//		 },
//		 "leather_bound_chest": {
//			"leather_bound_chest_ghost": {
//			   "display_name": "Coffre en cuir lié",
//			   "description": "Boîte de rangement."
//			}
//		 },
//		 "small_crate": {
//			"small_crate_ghost": {
//			   "display_name": "Petite caisse",
//			   "description": "Boîte de rangement."
//			}
//		 },
//		 "barrel": {
//			"barrel_ghost": {
//			   "display_name": "Coffre en cuir lié",
//			   "description": "Boîte de rangement."
//			}
//		 }
//	  },
//	  "crafting": {
//		 "workshop_outbox": {
//			"display_name": "Boîte de produit fini",
//			"description": "Stocke les fabrications terminées."
//		 }
//	  },
//	  "critters": {
//		 "poyo": {
//			"display_name": "Un Poyo",
//			"description": "Oiseaux sauvages dodus et savoureux.",
//			"poyo_egg": {
//			   "display_name": "Oeuf de poyo fécondé.",
//			   "description": "Est-il en train d'éclore?"
//			},
//			"young": {
//			   "display_name": "Poussin poyo",
//			   "description": "Piou piou !"
//			}
//		 },
//		 "rabbit": {
//			"display_name": "Lapin",
//			"description": "Om nom nom",
//			"rabbit_jerky": {
//			   "display_name": "Lapin séché"
//			}
//		 },
//		 "racoon": {
//			"display_name": "Raton laveur",
//			"description": "Petite créature de la forêt.",
//			"racoon_jerky": {
//			   "display_name": "Raton laveur séché"
//			}
//		 },
//		 "red_fox": {
//			"display_name": "Renard",
//			"description": "Petite créature de la forêt.",
//			"red_fox_jerky": {
//			   "display_name": "Renard séché"
//			}
//		 },
//		 "sheep": {
//			"display_name": "Un mouton",
//			"description": "Ssi moelleux !",
//			"unripe_description": "Ce mouton est encore tout nu.",
//			"sheep_young": {
//			   "display_name": "Un agneau",
//			   "description": "Awww !"
//			}
//		 },
//		 "squirrel": {
//			"display_name": "Écureuil",
//			"description": "Petite créature de la forêt",
//			"squirrel_jerky": {
//			   "display_name": "Écureuil séché"
//			}
//		 },
//		 "wolf": {
//			"display_name": "Un loup",
//			"description": "Grrr ! Rwar !"
//		 }
//	  },
//	  "crops": {
//		 "brightbell_crop": {
//			"display_name": "Brightbell Flower",
//			"description": "Just a flower.",
//			"growth_stage": {
//			   "001": {
//				  "name": "Brightbell Sprout",
//				  "description": "Stubby."
//			   },
//			   "003": {
//				  "name": "Brightbell",
//				  "description": "Beauty is its own reward."
//			   },
//			   "000": {
//				  "name": "Brightbell Seedling",
//				  "description": "Full of potential."
//			   },
//			   "002": {
//				  "name": "Brightbell Bud",
//				  "description": "Awkward, gangly stage."
//			   }
//			}
//		 },
//		 "carrot_crop": {
//			"display_name": "Carrot",
//			"description": "Fast-growning, but pretty bland on its own.",
//			"growth_stage": {
//			   "003": {
//				  "name": "Ripe Carrot",
//				  "description": "Delicious!"
//			   },
//			   "002": {
//				  "name": "Baby Carrot",
//				  "description": "Small. Bitter."
//			   },
//			   "001": {
//				  "name": "Carrot Sprout",
//				  "description": "Not edible yet!"
//			   },
//			   "000": {
//				  "name": "Carrot Seedling",
//				  "description": "A unrealized carrot."
//			   },
//			   "011": {
//				  "name": "Rotten Carrot",
//				  "description": "Moldy and disgusting."
//			   }
//			}
//		 },
//		 "corn_crop": {
//			"display_name": "Corn",
//			"description": "Slow-growning, but super nutritious crop.",
//			"growth_stage": {
//			   "003": {
//				  "name": "Ripe Corn",
//				  "description": "Eat me! Eat Me!"
//			   },
//			   "002": {
//				  "name": "Green Corn",
//				  "description": "Extremely unsatisfying to eat."
//			   },
//			   "001": {
//				  "name": "Corn Sprout",
//				  "description": "Not edible yet!"
//			   },
//			   "000": {
//				  "name": "Corn Seedling",
//				  "description": "Slow-mo, high-stakes gambling."
//			   },
//			   "011": {
//				  "name": "Corn Husk",
//				  "description": "It's dead."
//			   }
//			}
//		 },
//		 "foo_truffle": {
//			"silkweed_crop": {
//			   "display_name": "Silkweed",
//			   "description": "This plant's fiber can be spun into thread",
//			   "growth_stage": {
//				  "004": {
//					 "name": "Mature silkweed"
//				  },
//				  "001": {
//					 "name": "Silkweed sprout"
//				  },
//				  "000": {
//					 "name": "Silkweed seedling"
//				  },
//				  "019": {
//					 "name": "Rotten silkweed"
//				  },
//				  "003": {
//					 "name": "Immature silkweed"
//				  },
//				  "002": {
//					 "name": "Stubby silkweed"
//				  }
//			   }
//			}
//		 },
//		 "frostsnap_crop": {
//			"display_name": "Frostsnap Flower",
//			"description": "It's chill to the touch.",
//			"growth_stage": {
//			   "001": {
//				  "name": "Frostsnap Sprout",
//				  "description": "Stubby."
//			   },
//			   "003": {
//				  "name": "Frostsnap",
//				  "description": "Mysteriously cool."
//			   },
//			   "000": {
//				  "name": "Frostsnap Seedling",
//				  "description": "Full of potential."
//			   },
//			   "002": {
//				  "name": "Frostsnap Bud",
//				  "description": "Like a baby snowflake."
//			   }
//			}
//		 },
//		 "gingercap_crop": {
//			"display_name": "Turnip",
//			"description": "Fast-growing staple crop, but not particularly nutritious nor delicious.",
//			"growth_stage": {
//			   "003": {
//				  "name": "Ripe Turnip",
//				  "description": "Delicious!"
//			   },
//			   "002": {
//				  "name": "Baby Turnip",
//				  "description": "Small. Bitter."
//			   },
//			   "001": {
//				  "name": "Turnip Sprout",
//				  "description": "Not edible yet!"
//			   },
//			   "000": {
//				  "name": "Turnip Seedling",
//				  "description": "A unrealized turnip."
//			   },
//			   "011": {
//				  "name": "Rotten Turnip",
//				  "description": "Moldy and disgusting."
//			   }
//			}
//		 },
//		 "pumpkin_crop": {
//			"display_name": "Pumpkin",
//			"description": "Big, round, and fast-growing, but tasty it is not.",
//			"growth_stage": {
//			   "003": {
//				  "name": "Ripe pumpkin",
//				  "description": "Delicious!"
//			   },
//			   "002": {
//				  "name": "Baby pumpkin",
//				  "description": "Not edible yet!"
//			   },
//			   "001": {
//				  "name": "Pumpkin Sprout",
//				  "description": "Not edible yet!"
//			   },
//			   "000": {
//				  "name": "Pumpkin Seedling",
//				  "description": "A unrealized pumpkin."
//			   },
//			   "011": {
//				  "name": "Rotten pumpkin",
//				  "description": "Moldy and disgusting."
//			   }
//			}
//		 },
//		 "silkweed_crop": {
//			"display_name": "Silkweed",
//			"description": "This plant's fiber can be spun into thread",
//			"growth_stage": {
//			   "004": {
//				  "name": "Mature silkweed"
//			   },
//			   "001": {
//				  "name": "Silkweed sprout"
//			   },
//			   "000": {
//				  "name": "Silkweed seedling"
//			   },
//			   "019": {
//				  "name": "Rotten silkweed"
//			   },
//			   "003": {
//				  "name": "Immature silkweed"
//			   },
//			   "002": {
//				  "name": "Stubby silkweed"
//			   }
//			}
//		 },
//		 "tester_crop": {
//			"display_name": "Tester",
//			"description": "Steeped in the soil.",
//			"tester_crop_slow": {
//			   "display_name": "Tester_Slow",
//			   "description": "Steeped in the soil.",
//			   "growth_stage": {
//				  "001": {
//					 "name": "Ripe Tester",
//					 "description": "Delicious!"
//				  },
//				  "000": {
//					 "name": "Tester Seedling",
//					 "description": "A unrealized tester."
//				  }
//			   }
//			},
//			"growth_stage": {
//			   "001": {
//				  "name": "Ripe Tester",
//				  "description": "Delicious!"
//			   },
//			   "000": {
//				  "name": "Tester Seedling",
//				  "description": "A unrealized tester."
//			   }
//			}
//		 },
//		 "tester_crop_2": {
//			"display_name": "Tester_Slow",
//			"description": "Steeped in the soil.",
//			"growth_stage": {
//			   "001": {
//				  "name": "Ripe Tester",
//				  "description": "Delicious!"
//			   },
//			   "000": {
//				  "name": "Tester Seedling",
//				  "description": "A unrealized tester."
//			   }
//			}
//		 },
//		 "tester_silkweed_crop": {
//			"display_name": "Tester Silkweed",
//			"description": "This plant's fiber can be spun into thread",
//			"growth_stage": {
//			   "004": {
//				  "name": "Mature silkweed"
//			   },
//			   "001": {
//				  "name": "Silkweed sprout"
//			   },
//			   "000": {
//				  "name": "Silkweed seedling"
//			   },
//			   "019": {
//				  "name": "Rotten silkweed"
//			   },
//			   "003": {
//				  "name": "Immature silkweed"
//			   },
//			   "002": {
//				  "name": "Stubby silkweed"
//			   }
//			}
//		 },
//		 "turnip_crop": {
//			"display_name": "Turnip",
//			"description": "Fast-growing staple crop, but not particularly nutritious nor delicious.",
//			"growth_stage": {
//			   "003": {
//				  "name": "Ripe Turnip",
//				  "description": "Delicious!"
//			   },
//			   "002": {
//				  "name": "Baby Turnip",
//				  "description": "Small. Bitter."
//			   },
//			   "001": {
//				  "name": "Turnip Sprout",
//				  "description": "Not edible yet!"
//			   },
//			   "000": {
//				  "name": "Turnip Seedling",
//				  "description": "A unrealized turnip."
//			   },
//			   "011": {
//				  "name": "Rotten Turnip",
//				  "description": "Moldy and disgusting."
//			   }
//			}
//		 },
//		 "wheat_crop": {
//			"display_name": "Wheat",
//			"description": "Amber wave of grain.",
//			"growth_stage": {
//			   "003": {
//				  "name": "Ripe wheat",
//				  "description": "Ready for harvest!"
//			   },
//			   "002": {
//				  "name": "Immature wheat",
//				  "description": "Not ready for harvest"
//			   },
//			   "001": {
//				  "name": "Wheat Sprout",
//				  "description": "Not ready for harvest"
//			   },
//			   "000": {
//				  "name": "Wheat Seedling",
//				  "description": "Not ready for harvest"
//			   },
//			   "011": {
//				  "name": "Wheat Husk",
//				  "description": "It's dead."
//			   }
//			}
//		 },
//		 "oak_tree_crop": {
//			"display_name": "Oak Tree Sapling",
//			"description": "Out of trees? Get ready to participate in reforestation.",
//			"growth_stage": {
//			   "001": {
//				  "name": "Oak Tree Seedling",
//				  "description": "It's just getting started."
//			   },
//			   "003": {
//				  "name": "Oak Tree Sapling",
//				  "description": "Ready to be transferred to a bigger plot."
//			   },
//			   "000": {
//				  "name": "Acorn",
//				  "description": "Even a mighty tree has humble beginnings."
//			   },
//			   "002": {
//				  "name": "Oak Tree Sprout",
//				  "description": "Reach for the sun, little oakling."
//			   }
//			}
//		 }
//	  },
//	  "decoration": {
//		 "banner_wall_big": {
//			"banner_wall_big_ghost": {
//			   "display_name": "Grande bannière murale",
//			   "description": "Affichez votre sentiment de fierté envers votre ville avec cette bannière."
//			}
//		 },
//		 "banner_wall_small": {
//			"banner_wall_small_ghost": {
//			   "display_name": "Petite bannière murale",
//			   "description": "Affichez votre sentiment de fierté envers votre ville avec cette bannière."
//			}
//		 },
//		 "bird_bath": {
//			"bird_bath_ghost": {
//			   "display_name": "Bassin à oiseau",
//			   "description": "Tranquille."
//			}
//		 },
//		 "brightbell": {
//			"brightbell_ghost": {
//			   "display_name": "Hémérocalle",
//			   "description": "Juste une fleur."
//			}
//		 },
//		 "crate": {
//			"display_name": "Une caisse"
//		 },
//		 "curtains": {
//			"curtains_ghost": {
//			   "display_name": "Rideau",
//			   "description": "Habille une fenêtre."
//			}
//		 },
//		 "firepit": {
//			"firepit_ghost": {
//			   "display_name": "Feu de camp",
//			   "description": "Fournit chaleur et la lumiére"
//			}
//		 },
//		 "firepit_skulls": {
//			"firepit_skulls_ghost": {
//			   "display_name": "Méchant feu de camp",
//			   "description": "Are those....ew."
//			}
//		 },
//		 "frostsnap": {
//			"frostsnap_ghost": {
//			   "display_name": "Perçe-neige",
//			   "description": "C'est froid au toucher !"
//			}
//		 },
//		 "fur_rug": {
//			"fur_rug_ghost": {
//			   "display_name": "Tapis de fourrure",
//			   "description": "Fabriqué à partir de peaux d'animaux."
//			}
//		 },
//		 "gargoyle": {
//			"gargoyle_ghost": {
//			   "display_name": "Gargouille décorative murale",
//			   "description": "Une sculpture de style gothique pour décorer vos murs."
//			}
//		 },
//		 "gilded_crimson_rug": {
//			"gilded_crimson_rug_ghost": {
//			   "display_name": "Tapis doré cramoisie",
//			   "description": "Si royale"
//			}
//		 },
//		 "loot_chest": {
//			"display_name": "Un grand coffre",
//			"description": "Il contient du butin !"
//		 },
//		 "stone_brazier": {
//			"stone_brazier_ghost": {
//			   "display_name": "Brasero en pierre",
//			   "description": "Fournit un feu chaleureux et confortable la nuit"
//			}
//		 },
//		 "stone_garden_lantern": {
//			"stone_garden_lantern_ghost": {
//			   "display_name": "Lanterne de jardin en pierre",
//			   "description": "Une lanterne à l'ancienne donnant une bonne mabiance."
//			}
//		 },
//		 "stone_wall_lantern": {
//			"stone_wall_lantern_ghost": {
//			   "display_name": "Lanterne murale en pierre",
//			   "description": "Se fixe facilement aux murs"
//			}
//		 },
//		 "tapestry_wall": {
//			"tapestry_wall_ghost": {
//			   "display_name": "Tapisserie murale",
//			   "description": "Une scène décorative, tissé en fil et cordon colorés."
//			}
//		 },
//		 "throw_rug": {
//			"throw_rug_ghost": {
//			   "display_name": "Tapis décoratif",
//			   "description": "Illumine ce vieux sol poussiéreux."
//			}
//		 },
//		 "tower_brazier": {
//			"tower_brazier_ghost": {
//			   "display_name": "Tour brazero",
//			   "description": "Fournit un feu chaleureux et confortable la nuit"
//			}
//		 },
//		 "wall_crest": {
//			"wall_crest_ghost": {
//			   "display_name": "Écussion mural",
//			   "description": "Juste pour le spectacle."
//			}
//		 },
//		 "window_box_brightbell": {
//			"window_box_brightbell_ghost": {
//			   "display_name": "Jardinière d'hémérocalle",
//			   "description": "Un foyer coquet pour la plante."
//			}
//		 },
//		 "window_box_frostsnap": {
//			"window_box_frostsnap_ghost": {
//			   "display_name": "Jardinière de perçe-neige",
//			   "description": "Un foyer coquet pour la plante."
//			}
//		 },
//		 "wooden_garden_lantern": {
//			"wooden_garden_lantern_ghost": {
//			   "display_name": "Lanterne de jardin en bois",
//			   "description": "Une source de lumière compacte."
//			}
//		 },
//		 "wooden_garden_lantern_fine": {
//			"wooden_garden_lantern_fine_ghost": {
//			   "display_name": "Belle lanterne de jardin",
//			   "description": "Une source de lumière compacte."
//			}
//		 },
//		 "wooden_sign": {
//			"wooden_sign_ghost": {
//			   "display_name": "Enseigne murale en bois",
//			   "description": "L'expression d'une intention future."
//			}
//		 },
//		 "wooden_sign_blacksmith": {
//			"wooden_sign_blacksmith_ghost": {
//			   "display_name": "Enseigne murale de forgeron",
//			   "description": "Une enseigne avec la marque du forgeron."
//			}
//		 },
//		 "wooden_sign_carpenter": {
//			"wooden_sign_carpenter_ghost": {
//			   "display_name": "Enseigne murale de menuisier",
//			   "description": "Une enseigne avec la marque du menuisier."
//			}
//		 },
//		 "wooden_sign_mason": {
//			"wooden_sign_mason_ghost": {
//			   "display_name": "Enseigne murale de maçon",
//			   "description": "Une enseigne avec la marque du maçon."
//			}
//		 },
//		 "wooden_sign_weaver": {
//			"wooden_sign_weaver_ghost": {
//			   "display_name": "Enseigne murale de tisserand",
//			   "description": "Une enseigne avec la marque du tisserand."
//			}
//		 },
//		 "wooden_wall_lantern": {
//			"wooden_wall_lantern_ghost": {
//			   "display_name": "Lanterne murale en bois",
//			   "description": "Se fixe facilement aux murs"
//			}
//		 },
//		 "wooden_wall_lantern_fine": {
//			"wooden_wall_lantern_fine_ghost": {
//			   "display_name": "Belle lanterne murale en bois",
//			   "description": "Se fixe facilement aux murs"
//			}
//		 }
//	  },
//	  "food": {
//		 "berries": {
//			"berry_basket": {
//			   "display_name": "Basket of Berries",
//			   "description": "Creme of the caveman diet."
//			},
//			"berry_serving": {
//			   "display_name": "Plate of berries",
//			   "description": "Todo: Invent whipped cream."
//			}
//		 },
//		 "corn": {
//			"amazing_corn_basket": {
//			   "display_name": "Amazing Basket of Maize",
//			   "description": "Super nutritous corn."
//			},
//			"amazing_corn_serving": {
//			   "display_name": "Amazing Maize",
//			   "description": "Heavenly nutritious."
//			},
//			"corn_basket": {
//			   "display_name": "Basket of Corn",
//			   "description": "Sweet and crunchy."
//			},
//			"corn_serving": {
//			   "display_name": "Corn Cob",
//			   "description": "Crunch and spray."
//			}
//		 },
//		 "flour": {
//			"display_name": "Sack of Flour",
//			"description": "Perfect for making bread"
//		 },
//		 "meat_stew": {
//			"meat_stew": {
//			   "display_name": "Savory Meat Stew",
//			   "description": "Warm and delicious"
//			},
//			"meat_stew_serving": {
//			   "display_name": "Bowl of Savory Meat Stew"
//			}
//		 },
//		 "peasant_bread": {
//			"peasant_bread": {
//			   "display_name": "Peasant Bread",
//			   "description": "A crusty, basic bread."
//			},
//			"peasant_bread_serving": {
//			   "display_name": "Slice of Peasant Bread"
//			}
//		 },
//		 "pumpkin": {
//			"pumpkin_basket": {
//			   "display_name": "Pumpkin Basket",
//			   "description": "Ready for eating"
//			},
//			"pumpkin_serving": {
//			   "display_name": "Pumpkin Mush",
//			   "description": "Delicious. Really..."
//			}
//		 },
//		 "sheep_jerky": {
//			"display_name": "Rack of Mutton"
//		 },
//		 "veggie_stew": {
//			"veggie_stew": {
//			   "display_name": "Vegetable Stew",
//			   "description": "Warm and delicious"
//			},
//			"veggie_stew_serving": {
//			   "display_name": "Bowl of Veggie Stew",
//			   "description": "Delicious!"
//			}
//		 },
//		 "wheat_bale": {
//			"display_name": "Bale of Wheat",
//			"description": "Ready for use"
//		 },
//		 "egg": {
//			"display_name": "An Egg",
//			"description": "An eggcellent ingredient for cooking."
//		 },
//		 "corn_bread": {
//			"corn_bread": {
//			   "display_name": "Corn Bread",
//			   "description": "Toasty and golden brown."
//			},
//			"corn_bread_serving": {
//			   "display_name": "Piece of Corn Bread"
//			}
//		 },
//		 "poyo_meat": {
//			"display_name": "Raw Poyo Meat",
//			"description": "I hear it takes like poyo."
//		 },
//		 "poyo_pot_pie": {
//			"poyo_pot_pie": {
//			   "display_name": "Poyo Pot Pie",
//			   "description": "Warm and delicious."
//			},
//			"poyo_pot_pie_serving": {
//			   "display_name": "Slice of Poyo Pot Pie",
//			   "description": "Mmm ... pie."
//			}
//		 },
//		 "omelette": {
//			"omelette": {
//			   "display_name": "Omelette",
//			   "description": "Delicious egg wrapped meat and veggies"
//			},
//			"omelette_serving": {
//			   "display_name": "Serving of Omelette",
//			   "description": "But why would you share?"
//			}
//		 },
//		 "roast_poyo": {
//			"roast_poyo": {
//			   "display_name": "Roast Poyo",
//			   "description": "Nice and juicy."
//			},
//			"roast_poyo_serving": {
//			   "display_name": "Serving of Roast Poyo"
//			}
//		 },
//		 "fried_eggs": {
//			"fried_eggs": {
//			   "display_name": "Fried Eggs",
//			   "description": "Fried and delicious"
//			},
//			"fried_eggs_serving": {
//			   "display_name": "Serving of Fried Eggs"
//			}
//		 },
//		 "sheep_feed": {
//			"display_name": "Sheep Feed",
//			"description": "Give to sheep for a supplement to grazing.",
//			"sheep_feed_ground": {
//			   "display_name": "Sheep Feed",
//			   "description": "Food for sheep"
//			}
//		 },
//		 "poyo_feed": {
//			"poyo_feed": {
//			   "display_name": "Poyo Feed",
//			   "description": "For feeding poyos."
//			},
//			"poyo_feed_ground": {
//			   "display_name": "Poyo Feed",
//			   "description": "Poyos love to eat this stuff."
//			}
//		 },
//		 "rabbit_feed": {
//			"display_name": "Rabbit Feed",
//			"description": "For rabbits",
//			"rabbit_feed_ground": {
//			   "display_name": "Rabbit Feed",
//			   "description": "Food for rabbits"
//			}
//		 }
//	  },
//	  "furniture": {
//		 "arch_backed_chair": {
//			"arch_backed_chair_ghost": {
//			   "display_name": "Cathedral-Arch Chair",
//			   "description": "Classy like piety."
//			}
//		 },
//		 "arch_backed_chair_fine": {
//			"arch_backed_chair_fine_ghost": {
//			   "display_name": "Fine Cathedral-Arch Chair",
//			   "description": "Classy like piety."
//			}
//		 },
//		 "comfy_bed": {
//			"comfy_bed_ghost": {
//			   "display_name": "Comfy Bed",
//			   "description": "I dreamed... of flying sheep."
//			}
//		 },
//		 "comfy_bed_fine": {
//			"comfy_bed_fine_ghost": {
//			   "display_name": "Fine Comfy Bed",
//			   "description": "I dreamed... of flying sheep."
//			}
//		 },
//		 "comfy_chair": {
//			"comfy_chair_ghost": {
//			   "display_name": "Comfy Chair",
//			   "description": "For sitting!"
//			}
//		 },
//		 "comfy_chair_fine": {
//			"comfy_chair_fine_ghost": {
//			   "display_name": "Fine Comfy Chair",
//			   "description": "For sitting!"
//			}
//		 },
//		 "dining_table": {
//			"dining_table_ghost": {
//			   "display_name": "Dining Table",
//			   "description": "Sitting down to eat is a sign of civilization."
//			}
//		 },
//		 "dining_table_fine": {
//			"dining_table_fine_ghost": {
//			   "display_name": "Fine Dining Table",
//			   "description": "Sitting down to eat is a sign of civilization."
//			}
//		 },
//		 "dresser": {
//			"dresser_ghost": {
//			   "display_name": "Wooden Dresser",
//			   "description": "Decorative in the absence of belongings."
//			}
//		 },
//		 "dresser_fine": {
//			"dresser_fine_ghost": {
//			   "display_name": "Fine Dresser",
//			   "description": "Decorative in the absence of belongings."
//			}
//		 },
//		 "not_much_of_a_bed": {
//			"not_much_of_a_bed_ghost": {
//			   "display_name": "Mean Bed",
//			   "description": "Mean as in poor, not cruel. Though it's that too."
//			}
//		 },
//		 "park_bench": {
//			"park_bench_ghost": {
//			   "display_name": "Wooden Park Bench",
//			   "description": "Outdoor seating for moments of relaxation"
//			}
//		 },
//		 "park_bench_fine": {
//			"park_bench_fine_ghost": {
//			   "display_name": "Fine Park Bench",
//			   "description": "Outdoor seating for moments of relaxation"
//			}
//		 },
//		 "simple_wooden_chair": {
//			"simple_wooden_chair_ghost": {
//			   "display_name": "Simple Wooden Chair",
//			   "description": "For sitting"
//			}
//		 },
//		 "simple_wooden_chair_fine": {
//			"simple_wooden_chair_fine_ghost": {
//			   "display_name": "Fine Wooden Chair",
//			   "description": "For sitting"
//			}
//		 },
//		 "stone_bench": {
//			"stone_bench_ghost": {
//			   "display_name": "Stone Bench",
//			   "description": "Outdoor seating for moments of relaxation"
//			}
//		 },
//		 "stone_chair": {
//			"stone_chair_ghost": {
//			   "display_name": "Stone Chair",
//			   "description": "For sitting"
//			}
//		 },
//		 "stone_table": {
//			"stone_table_ghost": {
//			   "display_name": "Stone Table",
//			   "description": "Its weight adds a sense of gravitas."
//			}
//		 },
//		 "table_for_one": {
//			"table_for_one_ghost": {
//			   "display_name": "Table for One",
//			   "description": "Dining furniture for introverts."
//			}
//		 },
//		 "table_for_one_fine": {
//			"table_for_one_fine_ghost": {
//			   "display_name": "Fine Table for One",
//			   "description": "Dining furniture for introverts."
//			}
//		 },
//		 "tombstone": {
//			"tombstone_ghost": {
//			   "display_name": "R.I.P. [str(self.unit_info.custom_name)]",
//			   "description": "[str(self.unit_info.custom_name)] will always be remembered."
//			}
//		 },
//		 "writing_desk": {
//			"writing_desk_ghost": {
//			   "display_name": "Writing Desk",
//			   "description": "Furniture"
//			}
//		 },
//		 "writing_desk_fine": {
//			"writing_desk_fine_ghost": {
//			   "display_name": "Fine Writing Desk",
//			   "description": "Furniture"
//			}
//		 }
//	  },
//	  "generic": {
//		 "default_object": {
//			"display_name": "Default object",
//			"description": "Mysterious"
//		 }
//	  },
//	  "gizmos": {
//		 "camp_standard": {
//			"camp_standard_ghost": {
//			   "display_name": "Camp Standard",
//			   "description": "Use to mark territory, civilizedly."
//			}
//		 },
//		 "control_attack_banner": {
//			"display_name": "Attack Banner",
//			"description": "Attack!!!!"
//		 },
//		 "control_defend_banner": {
//			"display_name": "Defend Banner",
//			"description": "Hold this ground in Town Defense mode"
//		 }
//	  },
//	  "loot": {
//		 "gold": {
//			"display_name": "Chest of Gold Coins",
//			"description": "It's [str(self.item.stacks)] coins!"
//		 }
//	  },
//	  "monsters": {
//		 "forest": {
//			"ent": {
//			   "display_name": "Ent",
//			   "description": "Guardian of the forest"
//			}
//		 },
//		 "goblins": {
//			"decoration": {
//			   "banner": {
//				  "display_name": "A banner"
//			   },
//			   "skull_stake": {
//				  "display_name": "A stake"
//			   }
//			},
//			"goblin": {
//			   "display_name": "[str(self.unit_info.custom_name)]",
//			   "description": "Attracted to shiny things"
//			},
//			"goblin_barricade": {
//			   "display_name": "A barricade"
//			},
//			"goblin_boss_banner": {
//			   "goblin_boss_banner_ghost": {
//				  "display_name": "Ogo Skullbonker's Standard",
//				  "description": "Clearly indicates goblin-boss-status"
//			   }
//			},
//			"goblin_boss_hut": {
//			   "display_name": "Boss Hut",
//			   "description": "Dirty white, like the color of winter."
//			},
//			"goblin_chief_hut": {
//			   "goblin_tent": {
//				  "display_name": "A Tent",
//				  "description": "Made from crudely-sewn animal hides"
//			   }
//			},
//			"goblin_flute": {
//			   "broken_flute": {
//				  "display_name": "Broken Flute",
//				  "description": "Produces pathetically wheezy wailing."
//			   },
//			   "mountains_flute": {
//				  "display_name": "Mountain's Lullabye Flute",
//				  "description": "Pitched to soothe Mountain's soul."
//			   },
//			   "mountains_flute_iconic": {
//				  "display_name": "Mountain's Lullabye Flute",
//				  "description": "Pitched to soothe Mountain's soul."
//			   }
//			},
//			"goblin_hut": {
//			   "display_name": "A Tent",
//			   "description": "Made from crudely-sewn animal hides"
//			},
//			"goblin_large_totem": {
//			   "display_name": "Large totem"
//			},
//			"goblin_small_totem": {
//			   "display_name": "Small totem"
//			},
//			"goblin_soldier": {
//			   "display_name": "Goblin Soldier",
//			   "description": "Gobble, gobble, gobble..."
//			},
//			"goblin_soothsayer_tent": {
//			   "display_name": "The Soothsayer's Tent",
//			   "description": "Cobbled together out of luxurious scraps"
//			},
//			"goblin_tent": {
//			   "display_name": "A Tent",
//			   "description": "Made from crudely-sewn animal hides"
//			},
//			"goblin_throne": {
//			   "display_name": "Goblin Throne",
//			   "description": "Made of wood, bone, and ego"
//			},
//			"goblin_wolf": {
//			   "display_name": "Goblin Raiding Wolf",
//			   "description": "Bred to inspire terror"
//			},
//			"orc": {
//			   "display_name": "A Zombie",
//			   "description": "It yearns for flesh",
//			   "male": {
//				  "zombie_male": {
//					 "display_name": "A Zombie",
//					 "description": "It yearns for flesh"
//				  }
//			   }
//			},
//			"skull_trophy": {
//			   "skull_trophy_ghost": {
//				  "display_name": "Goblin honor token",
//				  "description": "Wooden badge of the goblin's clan"
//			   }
//			},
//			"wolf_cage": {
//			   "display_name": "A wolf cage",
//			   "description": "Signals nappytime for its inhabitants."
//			}
//		 },
//		 "undead": {
//			"skeleton": {
//			   "display_name": "A Skeleton",
//			   "description": "It yearns for flesh"
//			},
//			"zombie": {
//			   "display_name": "A Zombie",
//			   "description": "It yearns for flesh",
//			   "male": {
//				  "zombie_male": {
//					 "display_name": "A Zombie",
//					 "description": "It yearns for flesh"
//				  }
//			   }
//			}
//		 }
//	  },
//	  "pets": {
//		 "collie": {
//			"display_name": "Collie",
//			"description": "Si brave!"
//		 },
//		 "dragon_whelp": {
//			"display_name": "Lapin",
//			"description": "Om nom nom"
//		 },
//		 "kitten": {
//			"display_name": "Chaton",
//			"description": "Il est si mignon!"
//		 },
//		 "mammoth": {
//			"display_name": "Bébé mamouth",
//			"description": "Si poilu!"
//		 }
//	  },
//	  "plants": {
//		 "berry_bush": {
//			"display_name": "Berry Bush",
//			"description": "Harvestable for a meager food supply.",
//			"unripe_description": "Not yet ripe for harvest."
//		 },
//		 "brightbell_plant": {
//			"display_name": "Wild Brightbell",
//			"description": "A harvestable wild flower"
//		 },
//		 "carrot": {
//			"carrot_basket": {
//			   "display_name": "Basket of Carrots",
//			   "description": "Lined up in neat rows."
//			},
//			"carrot_serving": {
//			   "display_name": "A carrot",
//			   "description": "Tiny. Bitter."
//			}
//		 },
//		 "frostsnap_plant": {
//			"display_name": "Wild Frost Snap",
//			"description": "A harvestable wild flower"
//		 },
//		 "silkweed": {
//			"silkweed": {
//			   "display_name": "Wild silkweed",
//			   "description": "This plant's fiber can be spun into thread.",
//			   "unripe_description": "This plant has been harvested and hasn't grown back yet."
//			}
//		 },
//		 "tester": {
//			"tester_basket": {
//			   "display_name": "Basket of Testers",
//			   "description": "Juicy and exciting!"
//			},
//			"tester_serving": {
//			   "display_name": "A Tester",
//			   "description": "Used as shields by princesses."
//			}
//		 },
//		 "turnip": {
//			"turnip_basket": {
//			   "display_name": "Basket of Turnips",
//			   "description": "Juicy and exciting!"
//			},
//			"turnip_serving": {
//			   "display_name": "A Turnip",
//			   "description": "Tiny. Bitter."
//			}
//		 },
//		 "cactus_plant": {
//			"display_name": "Wild Cactus",
//			"description": "A harvestable wild flower"
//		 },
//		 "tumbleweed": {
//			"display_name": "Tumbleweed",
//			"description": "Doesn't do anything"
//		 }
//	  },
//	  "rabbit": {
//		 "lantern_relic": {
//			"lantern_relic_ghost": {
//			   "display_name": "Relique ancienne",
//			   "description": "S'effrite avec l'âge"
//			}
//		 },
//		 "rabbit_statue": {
//			"display_name": "Un ancien monument",
//			"description": "Moussu, mais la pierre est encore bonne..."
//		 }
//	  },
//	  "refined": {
//		 "bronze_ingot": {
//			"display_name": "Lingot de bronze",
//			"description": "Une barre de bronze pur."
//		 },
//		 "cloth_bolt": {
//			"display_name": "Rouleau d'étoffe",
//			"description": "Doux et réconfortant."
//		 },
//		 "copper_ingot": {
//			"display_name": "Lingot de cuivre",
//			"description": "Une barre de bronze pur."
//		 },
//		 "gold_ingot": {
//			"display_name": "Lingot d'or",
//			"description": "Une barre d'or pur. Un matériau adapté pour la création de biens."
//		 },
//		 "iron_ingot": {
//			"display_name": "Lingot de fer",
//			"description": "Une barre de fer pur."
//		 },
//		 "leather_bolt": {
//			"display_name": "Rouleau de cuir",
//			"description": "Souple mais durable."
//		 },
//		 "silver_ingot": {
//			"display_name": "Lingot d'argent",
//			"description": "A bar of pure silver."
//		 },
//		 "steel_ingot": {
//			"display_name": "Steel Ingot",
//			"description": "Une barre de bronze pur."
//		 },
//		 "stone_bricks": {
//			"display_name": "Pile de briques en pierre",
//			"description": "Élément clé pour les constructions en pierre."
//		 },
//		 "thread": {
//			"display_name": "Bobine de fil",
//			"description": "Personne ne pensera jamais que cela a commencé avec un mouton. Ou une plante."
//		 },
//		 "tin_ingot": {
//			"display_name": "Lingot d'étain",
//			"description": "Une barre d'étain pur."
//		 }
//	  },
//	  "resources": {
//		 "coal": {
//			"lump_of_coal": {
//			   "display_name": "Lump 'o Coal",
//			   "description": "A sizable chunk of solid coal."
//			}
//		 },
//		 "copper": {
//			"copper_ore": {
//			   "display_name": "Copper Ore",
//			   "description": "A chunk of raw copper"
//			}
//		 },
//		 "fiber": {
//			"silkweed_bundle": {
//			   "display_name": "Silkweed Bundle",
//			   "description": "Spinnable into thread"
//			},
//			"wool_bundle": {
//			   "display_name": "Bundle of Wool",
//			   "description": "Spinnable into thread"
//			}
//		 },
//		 "gold": {
//			"gold_ore": {
//			   "display_name": "Gold Ore",
//			   "description": "A chunk of raw gold"
//			}
//		 },
//		 "iron": {
//			"iron_ore": {
//			   "display_name": "Iron Ore",
//			   "description": "A chunk of raw iron"
//			}
//		 },
//		 "pelt": {
//			"rabbit_pelt": {
//			   "display_name": "Rabbit Pelt",
//			   "description": "Soft, supple, and quite dead."
//			},
//			"racoon_pelt": {
//			   "display_name": "Racoon pelt",
//			   "description": "Soft, supple, and quite dead"
//			},
//			"red_fox_pelt": {
//			   "display_name": "Fox pelt",
//			   "description": "Soft, supple, and quite dead"
//			},
//			"squirrel_pelt": {
//			   "display_name": "Squirrel pelt",
//			   "description": "Soft, supple, and quite dead"
//			},
//			"wolf_pelt": {
//			   "display_name": "Wolf pelt",
//			   "description": "From the hide of a terrifying creature"
//			}
//		 },
//		 "silver": {
//			"silver_ore": {
//			   "display_name": "Silver Ore",
//			   "description": "A chunk of raw silver"
//			}
//		 },
//		 "stone": {
//			"hunk_of_stone": {
//			   "display_name": "Hunk 'o Stone",
//			   "description": "A heavy, ordinary rock."
//			}
//		 },
//		 "tin": {
//			"tin_ore": {
//			   "display_name": "Tin Ore",
//			   "description": "A chunk of raw tin"
//			}
//		 },
//		 "wood": {
//			"juniper_log": {
//			   "display_name": "Juniper Log",
//			   "description": "A log. Made of wood."
//			},
//			"oak_log": {
//			   "display_name": "Oak Log",
//			   "description": "A log. Made of wood."
//			},
//			"pine_log": {
//			   "display_name": "Pine Log",
//			   "description": "A log. Made of wood."
//			},
//			"cactus_log": {
//			   "display_name": "Cactus Log",
//			   "description": "A log. Made of wood."
//			},
//			"palm_log": {
//			   "display_name": "Palm Log",
//			   "description": "A log. Made of wood."
//			},
//			"acacia_log": {
//			   "display_name": "Acacia Log",
//			   "description": "A log. Made of wood."
//			}
//		 }
//	  },
//	  "terrain": {
//		 "mining_zone": {
//			"display_name": "Mining Zone",
//			"description": "This terrain is designated for removal."
//		 },
//		 "tall_grass": {
//			"display_name": "Tall Grass",
//			"description": "Harvestable for thatch"
//		 },
//		 "tilled_dirt": {
//			"display_name": "Tilled Earth",
//			"description": "Dirty, in the purest sense."
//		 },
//		 "ui": {
//			"coal_block": {
//			   "display_name": "Coal Vein",
//			   "description": "Provides coal when mined."
//			},
//			"copper_block": {
//			   "display_name": "Copper Vein",
//			   "description": "Provides copper ore when mined."
//			},
//			"gold_block": {
//			   "display_name": "Gold Vein",
//			   "description": "Provides gold ore when mined."
//			},
//			"iron_block": {
//			   "display_name": "Iron Vein",
//			   "description": "Provides iron ore when mined."
//			},
//			"ore_block": {
//			   "display_name": "Ore block",
//			   "description": "Mine to get ore"
//			},
//			"silver_block": {
//			   "display_name": "Silver Vein",
//			   "description": "Provides silver ore when mined."
//			},
//			"tin_block": {
//			   "display_name": "Tin Vein",
//			   "description": "Provides tin ore when mined."
//			}
//		 }
//	  },
//	  "tools": {
//		 "mining_pick": {
//			"display_name": "Mining Pick",
//			"description": "For mining and picking"
//		 },
//		 "worker_axe": {
//			"display_name": "Worker's Axe",
//			"description": "..."
//		 },
//		 "worker_hammer": {
//			"display_name": "Worker's Hammer",
//			"description": "Everything looks like a nail when all you have is a hammer"
//		 }
//	  },
//	  "toys": {
//		 "ball": {
//			"display_name": "Leather ball"
//		 },
//		 "plushie_toy_rabbit": {
//			"plushie_toy_rabbit_ghost": {
//			   "display_name": "Plushie Toy Rabbit",
//			   "description": "A toy... for children of course."
//			}
//		 }
//	  },
//	  "trees": {
//		 "juniper_tree": {
//			"ancient_juniper_tree": {
//			   "display_name": "Ancient Juniper Tree",
//			   "description": "It radiates a mysterious aura"
//			},
//			"large_juniper_tree": {
//			   "display_name": "Large Juniper Tree",
//			   "description": "An impressive specimen."
//			},
//			"medium_juniper_tree": {
//			   "display_name": "Juniper Tree",
//			   "description": "Strong and tall."
//			},
//			"small_juniper_tree": {
//			   "display_name": "Small Juniper Tree",
//			   "description": "Just a sapling."
//			}
//		 },
//		 "palm_tree": {
//			"large_palm_tree": {
//			   "display_name": "Large Palm Tree",
//			   "description": "An impressive specimen."
//			},
//			"small_palm_tree": {
//			   "display_name": "Small Palm Tree",
//			   "description": "Just a sapling."
//			}
//		 },
//		 "acacia_tree": {
//			"large_acacia_tree": {
//			   "display_name": "Large Acacia Tree",
//			   "description": "It radiates a mysterious aura"
//			}
//		 },
//		 "joshua_tree": {
//			"large_joshua_tree": {
//			   "display_name": "Large Joshua Tree",
//			   "description": "A curious tree"
//			}
//		 },
//		 "pine_tree": {
//			"large_pine_tree": {
//			   "display_name": "Large Pine Tree",
//			   "description": "100's of years old. Too bad..."
//			},
//			"medium_pine_tree": {
//			   "display_name": "Medium Pine Tree",
//			   "description": "Sturdy, in the prime of life."
//			},
//			"small_pine_tree": {
//			   "display_name": "Small Pine Tree",
//			   "description": "Just a sapling."
//			}
//		 },
//		 "cactus_tree": {
//			"large_cactus_tree": {
//			   "display_name": "Large Cactus",
//			   "description": "An impressive specimen."
//			},
//			"small_cactus_tree": {
//			   "display_name": "Small Cactus",
//			   "description": "Small and prickly."
//			}
//		 },
//		 "oak_tree": {
//			"ancient_oak_tree": {
//			   "display_name": "Ancient Oak Tree",
//			   "description": "It radiates a mysterious aura"
//			},
//			"large_oak_tree": {
//			   "display_name": "Large Oak Tree",
//			   "description": "100's of years old. Too bad..."
//			},
//			"medium_oak_tree": {
//			   "display_name": "Medium Oak Tree",
//			   "description": "Sturdy, in the prime of life."
//			},
//			"small_oak_tree": {
//			   "display_name": "Small Oak Tree",
//			   "description": "Slightly larger than a sapling."
//			},
//			"sapling_oak_tree": {
//			   "description": "Plant it in the earth and watch it grow.",
//			   "sapling_oak_tree_ghost": {
//				  "display_name": "Oak Tree Sapling",
//				  "description": "Plant it in the earth and watch it grow."
//			   },
//			   "sapling_oak_tree_iconic": {
//				  "description": "Plant it in the earth and watch it grow."
//			   }
//			}
//		 }
//	  },
//	  "weapons": {
//		 "bronze_mace": {
//			"display_name": "Bronze Mace",
//			"description": "Precisely engineered for maximum bashing.",
//			"bronze_mace_iconic": {
//			   "display_name": "Bronze Mace",
//			   "description": "For flattening faces"
//			}
//		 },
//		 "bronze_sword": {
//			"display_name": "Bronze Short Sword",
//			"description": "Basic, but better than fighting with a sharpened stick!",
//			"bronze_sword_iconic": {
//			   "display_name": "Bronze Sword",
//			   "description": "Pointy. Shiny."
//			}
//		 },
//		 "dagger": {
//			"display_name": "Dagger",
//			"description": "Pointy. Dangerous.",
//			"dagger_iconic": {
//			   "display_name": "Dagger",
//			   "description": "Pointy. Dangerous."
//			}
//		 },
//		 "giant_bone_axe": {
//			"display_name": "Giant Bone Axe",
//			"description": "Carved from the clavical of some great beast.",
//			"giant_bone_axe_iconic": {
//			   "display_name": "Giant Bone Axe",
//			   "description": "Carved from the clavical of some great beast."
//			}
//		 },
//		 "giant_bone_mace": {
//			"display_name": "Giant Bone Mace",
//			"description": "Heavy, it packs a whallop.",
//			"giant_bone_mace_iconic": {
//			   "display_name": "Giant Bone Mace",
//			   "description": "For flattening faces"
//			}
//		 },
//		 "iron_mace": {
//			"display_name": "Iron Mace",
//			"description": "Heavy, it packs a whallop.",
//			"iron_mace_iconic": {
//			   "display_name": "Iron Mace",
//			   "description": "For flattening faces"
//			}
//		 },
//		 "iron_pike": {
//			"display_name": "Iron Pike",
//			"description": "Sharp. Long. Pointy.",
//			"iron_pike_iconic": {
//			   "display_name": "Iron pike",
//			   "description": "Sharp. Long. Pointy."
//			}
//		 },
//		 "jagged_cleaver": {
//			"display_name": "Jagged Cleaver",
//			"description": "A crude, ineffective weapon",
//			"jagged_cleaver_iconic": {
//			   "display_name": "Jagged Cleaver",
//			   "description": "A crude, ineffective weapon"
//			}
//		 },
//		 "long_sword": {
//			"display_name": "Long Sword",
//			"description": "Sharp, with extra reach. A faithful weapon.",
//			"long_sword_iconic": {
//			   "display_name": "Long Sword",
//			   "description": "Pointy. Shiny."
//			}
//		 },
//		 "npc_animal_prod": {
//			"display_name": "Wicked Animal Prod",
//			"description": "Keeps the fuzzies in line"
//		 },
//		 "short_sword": {
//			"display_name": "Short Sword",
//			"description": "Stubby, but its steel blade keeps an edge.",
//			"short_sword_iconic": {
//			   "display_name": "short Sword",
//			   "description": "Pointy. Shiny."
//			}
//		 },
//		 "spiked_wooden_mace": {
//			"display_name": "Spiked Wooden Mace",
//			"description": "Nasty, pointy spikes"
//		 },
//		 "stone_maul": {
//			"display_name": "Stone Maul",
//			"description": "The perfect tool for bludgeoning",
//			"stone_maul_iconic": {
//			   "display_name": "Stone Maul",
//			   "description": "For flattening faces"
//			}
//		 },
//		 "two_handed_sword": {
//			"display_name": "Two Handed Sword",
//			"description": "Double the hands, double the trouble.",
//			"two_handed_sword_iconic": {
//			   "display_name": "Two Handed Sword",
//			   "description": "Double the hands, double the trouble."
//			}
//		 },
//		 "wooden_sword": {
//			"display_name": "Épée en bois",
//			"description": "Tranche tes enemies avec la force du chêne",
//			"wooden_sword_iconic": {
//			   "display_name": "Épée en bois",
//			   "description": "Épée basique en bois."
//			},
//			"wooden_sword_talisman": {
//			   "display_name": "Épée en bois",
//			   "description": "Nécessaire pour promouvoir un hearthling en Footman."
//			}
//		 }
//	  }
//   },
//   "jobs": {
//	  "animal_trainer": {
//		 "animal_trainer_description": {
//			"display_name": "???",
//			"description": "???",
//			"requirements": "???"
//		 }
//	  },
//	  "archer": {
//		 "archer_description": {
//			"display_name": "???",
//			"description": "???",
//			"requirements": "???"
//		 }
//	  },
//	  "architect": {
//		 "architect_description": {
//			"display_name": "???",
//			"description": "???",
//			"requirements": "???"
//		 }
//	  },
//	  "armorsmith": {
//		 "armorsmith_description": {
//			"display_name": "???",
//			"description": "???",
//			"requirements": "???"
//		 }
//	  },
//	  "big_game_hunter": {
//		 "big_game_hunter_description": {
//			"display_name": "???",
//			"description": "???",
//			"requirements": "???"
//		 }
//	  },
//	  "blacksmith": {
//		 "blacksmith_description": {
//			"display_name": "Blacksmith",
//			"description": "The Blacksmith refines raw ore into metal bars, then uses those bars to craft weapons, armor, and building parts like gates.",
//			"requirements": "Blacksmith's Hammer, crafted by the Mason",
//			"workshop": {
//			   "name": "Backsmith's Workshop",
//			   "long_description": "The Blacksmith refines raw ore into metal bars, then uses those bars to craft weapons, armor, and building parts like gates."
//			},
//			"level_6_data": {
//			   "title": "Master Blacksmith",
//			   "perk_000_name": "The Armory",
//			   "perk_000_description": "The blacksmith's mastery of his trade allows him to create the finest weapons and armors seen since the forgotten Phoenix Empire."
//			},
//			"level_2_data": {
//			   "perk_000_name": "Iron Age!",
//			   "perk_000_description": "The blacksmith is now skilled enough to forge heavy items made of iron."
//			},
//			"level_4_data": {
//			   "perk_000_name": "Cold Steel",
//			   "perk_000_description": "Long hours at the forge have unlocked the secret of steel: sharper weapons and lighter armor."
//			},
//			"level_1_data": {
//			   "perk_000_name": "Bronze Age!",
//			   "perk_000_description": "The secrets of bronze are now available to the blacksmith."
//			},
//			"level_3_data": {
//			   "perk_000_name": "Artistic Inspiration",
//			   "perk_000_description": "When inspiration strikes, the blacksmith may embellish his works in unexpected ways."
//			}
//		 },
//		 "blacksmith_forge": {
//			"blacksmith_forge_ghost": {
//			   "display_name": "Forge",
//			   "description": "A sturdy, stone oven for heating metal"
//			}
//		 },
//		 "blacksmith_hammer": {
//			"display_name": "Blacksmith's Hammer",
//			"description": "Tools of the trade for a blacksmith.",
//			"blacksmith_hammer_iconic": {
//			   "display_name": "Blacksmith's Hammer",
//			   "description": "Tools of the trade for a blacksmith."
//			},
//			"blacksmith_hammer_talisman": {
//			   "display_name": "Blacksmith's Hammer",
//			   "description": "Tools of the trade for a blacksmith."
//			}
//		 },
//		 "blacksmith_outfit": {
//			"display_name": "Blacksmith Overalls",
//			"description": "Uniform for all blacksmiths"
//		 },
//		 "blacksmith_workbench": {
//			"blacksmith_workbench_ghost": {
//			   "display_name": "Blacksmith Anvil",
//			   "description": "Used by the Blacksmith for crafting."
//			}
//		 },
//		 "recipes": {
//			"basic_shield_recipe": {
//			   "description": "Grants the ability to completely block attacks.",
//			   "flavor": "Incredibly protective. Small children play turtle underneath.",
//			   "recipe_name": "Trusty Shield"
//			},
//			"iron_shield_recipe": {
//			   "description": "Heavy, but effective.",
//			   "flavor" : "'Buck up, recruit! Better the shield dent than you!' -Thredd, Man at Arms", 
//			   "recipe_name": "Iron Shield"
//			},
//			"bronze_breastplate_recipe": {
//			   "description": "Partial but sturdy coverage against blunt and edged weapons.",
//			   "recipe_name": "Bronze Breastplate",
//			   "flavor": "Design reminiscent of the Phoenix's Legions."
//			},
//			"bronze_ingot_recipe": {
//			   "description": "A bar of pure bronze. A suitable material for crafted goods.",
//			   "recipe_name": "Bronze Ingot",
//			   "flavor": "The masters of old considered its production, evidence of our triumph over the earth."
//			},
//			"bronze_mace_recipe": {
//			   "description": "Heavy, it packs a whallop.",
//			   "recipe_name": "Bronze Mace",
//			   "flavor": "The good news: there is no pointy end."
//			},
//			"bronze_sword_recipe": {
//			   "description": "Basic, but better than fighting with a sharpened stick!",
//			   "recipe_name": "Bronze Sword",
//			   "flavor": "Made in the shape of Braun's own blade."
//			},
//			"carpenter_saw_recipe": {
//			   "description": "Required to promote a hearthling into a Carpenter.",
//			   "recipe_name": "Carpenter's Saw",
//			   "flavor": "Now the circle can begin anew."
//			},
//			"copper_ingot_recipe": {
//			   "description": "A bar of pure copper. A suitable material for crafted goods.",
//			   "recipe_name": "Copper Ingot",
//			   "flavor": "Smooth and silky to the touch"
//			},
//			"gold_ingot_recipe": {
//			   "description": "A bar of pure gold. A suitable material for crafted goods.",
//			   "recipe_name": "Gold Ingot",
//			   "flavor": "The most expensive bludgeon ever."
//			},
//			"iron_ingot_recipe": {
//			   "description": "A bar of pure Iron. A suitable material for crafted goods.",
//			   "recipe_name": "Iron Ingot",
//			   "flavor": "To both swords and plowshares, what an egg is to a chicken."
//			},
//			"iron_mace_recipe": {
//			   "description": "Heavy, it packs a whallop.",
//			   "recipe_name": "Iron Mace",
//			   "flavor": "And Erin rested her forehead upon it, and the iron stole away enchantment and memory, together."
//			},
//			"iron_mail_recipe": {
//			   "description": "A full suit of heavy, durable iron armor.",
//			   "recipe_name": "Iron Mail",
//			   "flavor": "But he'd hidden his heart in an iron fortress, and no fey could touch it. --Songs of Evermarth"
//			},
//			"iron_pike_recipe": {
//			   "description": "Sharp. Long. Pointy.",
//			   "recipe_name": "Iron pike",
//			   "flavor": "'Coward,' Elden spat. 'Face me blade to blade, or no knight be you.'"
//			},
//			"long_sword_recipe": {
//			   "description": "Sharp, with extra reach. A faithful weapon.",
//			   "recipe_name": "Long Sword",
//			   "flavor": "'Hah! The only weapon worthy of specialization. --Lady Giest"
//			},
//			"weapons_name": "Weapons",
//			"smelt_name": "Smelting",
//			"armor_name": "Armor",
//			"tools_name": "Tools",
//			"short_sword_recipe": {
//			   "description": "Stubby, but its steel blade keeps an edge.",
//			   "recipe_name": "Short Sword",
//			   "flavor": "But, does it glow when orcs are near?"
//			},
//			"silver_ingot_recipe": {
//			   "description": "A bar of pure silver. A suitable material for crafted goods.",
//			   "recipe_name": "Silver Ingot",
//			   "flavor": "A pair of silver shoes once started a Phoenix war over currency."
//			},
//			"steel_ingot_recipe": {
//			   "description": "A bar of pure steel. A suitable material for crafted goods.",
//			   "recipe_name": "Steel Ingot",
//			   "flavor": "The beginning of the modern age."
//			},
//			"steel_mail_recipe": {
//			   "description": "A full suit of heavy, durable steel armor.",
//			   "recipe_name": "Full Platemail",
//			   "flavor": "Full Metal Jacket"
//			},
//			"tin_ingot_recipe": {
//			   "description": "A bar of pure tin. A suitable material for crafted goods.",
//			   "recipe_name": "Tin Ingot",
//			   "flavor": "Step 1: Beat thin. Step 2: Use to cover roof of town hall."
//			},
//			"trapper_knife_recipe": {
//			   "description": "Required to promote a hearthling into a Trapper.",
//			   "recipe_name": "Trapper's Knife",
//			   "flavor": "Keep your edge whisker sharp, boy, and cut quick. --Willard Foxghost"
//			},
//			"two_handed_sword_recipe": {
//			   "description": "Double the hands, double the trouble.",
//			   "recipe_name": "Two Handed Sword"
//			},
//			"blacksmith_forge_recipe": {
//			   "description": "Smelt metals into ingots.",
//			   "recipe_name": "Blacksmith's Forge",
//			   "flavor": "In flame, purity, in purity, strength. -Lucan Varius, Artifex Ignis"
//			},
//			"blacksmith_workbench_recipe": {
//			   "description": "Used to create weapons and armor out of ingots.",
//			   "recipe_name": "Blacksmith's Anvil",
//			   "flavor": "It is no coincidence that the metaphors of good character descend from work of the smith. -Lucan Varius, Artifex Ignis"
//			},
//			"workbenches_name": "Workbenches"
//		 }
//	  },
//	  "carpenter": {
//		 "carpenter_description": {
//			"display_name": "Carpenter",
//			"description": "The carpenter crafts tools and furniture from wood. The tools he makes unlocks several other jobs.",
//			"requirements": "Carpenter's saw, crafted by the Blacksmith.",
//			"workshop": {
//			   "name": "Carpenter's Workshop",
//			   "description": "insert description here",
//			   "long_description": "The carpenter makes things from wood. Things you will need...quite a lot.<p>So honestly, you should really make this guy first."
//			},
//			"level_6_data": {
//			   "title": "Master Carpenter",
//			   "perk_000_name": "10,000 Hours (not implemented)",
//			   "perk_000_description": "The carpenter's mastery of his trade allows him to come up with completely new ways of using wood."
//			},
//			"level_2_data": {
//			   "perk_000_name": "Collaborative Insight",
//			   "perk_000_description": "The carpenter is now skillful enough to use materials created by other crafters."
//			},
//			"level_4_data": {
//			   "perk_000_name": "Extended Catalog",
//			   "perk_000_description": "The carpenter now has the courage to try more elaborate projects."
//			},
//			"level_1_data": {
//			   "perk_000_name": "Standard Catalog",
//			   "perk_000_description": "The carpenter can now make a solid array of basic furniture."
//			},
//			"level_3_data": {
//			   "perk_000_name": "Artistic Inspiration",
//			   "perk_000_description": "When inspiration strikes, the carpenter may embellish his works in unexpected ways."
//			}
//		 },
//		 "carpenter_outfit": {
//			"display_name": "Carpenter Overalls",
//			"description": "Uniform for all carpenters"
//		 },
//		 "carpenter_saw": {
//			"display_name": "Carpenter's Saw",
//			"description": "Tools of the trade for a Carpenter.",
//			"carpenter_saw_iconic": {
//			   "display_name": "Carpenter's Saw",
//			   "description": "Basic level carpenter's saw."
//			},
//			"carpenter_saw_talisman": {
//			   "display_name": "Carpenter's Saw",
//			   "description": "Required to promote a hearthling into a Carpenter."
//			}
//		 },
//		 "carpenter_workbench": {
//			"carpenter_workbench_ghost": {
//			   "display_name": "Carpenter Workbench",
//			   "description": "Used by the Carpenter for crafting."
//			}
//		 },
//		 "carpenter_toolbench": {
//			"carpenter_toolbench_ghost": {
//			   "display_name": "Carpenter Toolbench",
//			   "description": "Used to make fancier kinds of furniture."
//			}
//		 },
//		 "recipes": {
//			"arch_backed_chair_recipe": {
//			   "description": "Just like a normal chair, except it impresses your neighbors. When sitting, food is 20% more satisfying.",
//			   "recipe_name": "Cathedral-Arch Chair",
//			   "flavor": "Design favored by the Church of Plenty."
//			},
//			"comfy_bed_recipe": {
//			   "description": "Eight hours will leave you as refreshed as the day you were born.",
//			   "recipe_name": "Comfy Bed",
//			   "flavor": "Nobody ever wants to get out. It makes emergency evacuations awkward."
//			},
//			"comfy_chair_recipe": {
//			   "description": "Its padded seat guarantees a 98% reducion in awkward splinters!",
//			   "recipe_name": "Comfy Chair",
//			   "flavor": "If pillows are good for the head, surely they're even better for the butt and back!"
//			},
//			"dining_table_recipe": {
//			   "description": "Allows a group of people to all eat together. Like grown ups.",
//			   "recipe_name": "Dining Table",
//			   "flavor": "Sitting down to eat is a sign of civilization."
//			},
//			"dresser_recipe": {
//			   "description": "A chest of drawers for storing clothing and personal possessions.",
//			   "recipe_name": "Wooden Dresser",
//			   "flavor": "Step 2: acquire personal possessions..."
//			},
//			"hoe_recipe": {
//			   "description": "Required to promote a hearthling into a Farmer.",
//			   "recipe_name": "Farmer's Hoe",
//			   "flavor": "Hoedown time!!!!"
//			},
//			"large_crate_recipe": {
//			   "description": "For compactly storing up to 32 items",
//			   "recipe_name": "Large Crate",
//			   "flavor": "Does the crate that stores all the things that do not store themselves, store itself?"
//			},
//			"leather_bound_chest_recipe": {
//			   "description": "For compactly storing up to 16 items",
//			   "recipe_name": "Leather Bound Chest",
//			   "flavor": "Like the one my granda had!"
//			},
//			"mason_chisel_recipe": {
//			   "description": "Required to promote a hearthling into a Mason.",
//			   "recipe_name": "Mason's Hammer & Chisel"
//			},
//			"not_much_of_a_bed_recipe": {
//			   "description": "Slightly more comfortable than sleeping on a board.",
//			   "recipe_name": "Mean Bed",
//			   "flavor": "Mean as in poor, not cruel. Though it's that too."
//			},
//			"park_bench_recipe": {
//			   "description": "Outdoor seating for moments of relaxation.",
//			   "recipe_name": "Wooden Park Bench",
//			   "flavor": "Life is like a plate of berries."
//			},
//			"picket_fence_gate_recipe": {
//			   "description": "Lets people through your picket fence.",
//			   "recipe_name": "Picket Fence Gate",
//			   "flavor": "Hope you like your neighbors!"
//			},
//			"picket_fence_recipe": {
//			   "description": "Keeps people off your property.",
//			   "recipe_name": "Picket Fence",
//			   "flavor": "If it's not white, is our life unfulfilled?"
//			},
//			"tools_weapons_name": "Tools & Weapons",
//			"storage_name": "Storage",
//			"building_parts_name": "Building Parts",
//			"armor_name": "Armor",
//			"furniture_name": "Furniture",
//			"workbench_name": "Workbenches",
//			"shepherds_crook_recipe": {
//			   "description": "Required to promote a hearthling into a Shepherd.",
//			   "recipe_name": "Shepherd's Crook",
//			   "flavor": "Can you tell me another story about The Shepard?"
//			},
//			"simple_wooden_chair_recipe": {
//			   "description": "When sitting, food is 20% more satisfying.",
//			   "recipe_name": "Simple Wooden Chair",
//			   "flavor": "Ten thousand years of reseach culminated in this four-legged design."
//			},
//			"small_crate_recipe": {
//			   "description": "For compactly storing up to 8 items",
//			   "recipe_name": "Small Crate",
//			   "flavor": "Does the crate that stores all the things that do not store themselves, store itself?"
//			},
//			"table_for_one_recipe": {
//			   "description": "Better than eating standing up. Unless you're watching your weight.",
//			   "recipe_name": "Table for One",
//			   "flavor": "Dining furniture for introverts."
//			},
//			"weaver_spindle_recipe": {
//			   "description": "Required to promote a hearthling into a Weaver.",
//			   "recipe_name": "Weaver's Spindle",
//			   "flavor": "From fiber, thread, from thread, fabric, from fabric, civilization."
//			},
//			"window_box_brightbell_recipe": {
//			   "description": "A planter box full of brightbell flowers, built to be placed below window frames.",
//			   "recipe_name": "Brightbell Window Box",
//			   "flavor": "A brightbell a day keeps the Ogres away!"
//			},
//			"window_box_frostsnap_recipe": {
//			   "description": "A planter box full of Frostsnap flowers, built to be placed below window frames.",
//			   "recipe_name": "Frostsnap Window Box",
//			   "flavor": "The capstone of an civilized dwelling."
//			},
//			"wooden_buckler_recipe": {
//			   "description": "Toughen up your foot soldiers... when you can actually equip them in a future alpha!",
//			   "recipe_name": "Wooden Buckler"
//			},
//			"wooden_diamond_window_recipe": {
//			   "description": "A more stylish window.",
//			   "recipe_name": "Wooden Diamond Window",
//			   "flavor": "The 45 degree turn adds sophistication."
//			},
//			"wooden_door_2_recipe": {
//			   "description": "Stronger than your average door.",
//			   "recipe_name": "Reinforced Wooden Door",
//			   "flavor": "This here pattern, I learned from the Squarefolk."
//			},
//			"wooden_door_recipe": {
//			   "description": "Minor obstacle for intruders.",
//			   "recipe_name": "Wooden Door",
//			   "flavor": "Privacy at last!"
//			},
//			"wooden_double_door_recipe": {
//			   "description": "Two doors are better than one",
//			   "recipe_name": "Wooden Double Door",
//			   "flavor": "Some people want to make an entrance... every day."
//			},
//			"wooden_garden_lantern_recipe": {
//			   "description": "A small lantern that's placed on the ground. Suitable for lighting paths or small gardens.",
//			   "recipe_name": "Wooden Garden Lantern",
//			   "flavor": "Practical and romantic!"
//			},
//			"wooden_shield_recipe": {
//			   "description": "Crude and basic, but allows the holder to occasionally block attacks.",
//			   "recipe_name": "Rough Wooden Shield",
//			   "flavor": "Better than an improvized wooden branch!"
//			},
//			"wooden_sign_blacksmith_recipe": {
//			   "description": "A sign with the mark of the blacksmith, to be placed on buildings.",
//			   "recipe_name": "Blacksmith's Wall-Mounted Sign",
//			   "flavor": "Specializing in heavy, pointy, dense things!"
//			},
//			"wooden_sign_carpenter_recipe": {
//			   "description": "A sign with the mark of the Carpenter, to be placed on buildings.",
//			   "recipe_name": "Carpenter's Wall-Mounted Sign",
//			   "flavor": "Get your wooden things right here!"
//			},
//			"wooden_sign_mason_recipe": {
//			   "description": "A sign with the mark of the Mason, to be placed on buildings.",
//			   "recipe_name": "Mason's Wall-Mounted Sign",
//			   "flavor": "Dense beautiful things that sometimes contain things that burn."
//			},
//			"wooden_sign_recipe": {
//			   "description": "A generic sign, to identify your buildings",
//			   "recipe_name": "Wooden Wall-Mounted Sign",
//			   "flavor": "But if it's *generic*, how will...? NM. (-sdee)"
//			},
//			"wooden_sign_weaver_recipe": {
//			   "description": "A sign with the mark of the Weaver, to be placed on buildings.",
//			   "recipe_name": "Weaver's Wall-Mounted Sign",
//			   "flavor": "Artisinally crafted fabrics and plushies!"
//			},
//			"wooden_sword_recipe": {
//			   "description": "Required to promote a hearthling into a Footman.",
//			   "recipe_name": "Wooden Practice Sword",
//			   "flavor": "Just pointy enough to get the job done."
//			},
//			"wooden_wall_lantern_recipe": {
//			   "description": "A simple lantern. Place on buildings to provide light at night.",
//			   "recipe_name": "Wooden Wall-mounted Lantern",
//			   "flavor": "So comfortinzzzzzzzz..."
//			},
//			"wooden_window_frame_recipe": {
//			   "description": "Lets light into the room.",
//			   "recipe_name": "Wooden Window Frame",
//			   "flavor": "So much for privacy..."
//			},
//			"writing_desk_recipe": {
//			   "description": "Not at all like a raven.",
//			   "recipe_name": "Writing Desk",
//			   "flavor": "...Except it can produce a few notes, tho they are very flat."
//			},
//			"carpenter_workbench_recipe": {
//			   "description": "Required to produce most of the Carpenter's recipes.",
//			   "recipe_name": "Carpenter Workbench",
//			   "flavor": "A sturdy, well-organized place for tools and crafts."
//			},
//			"carpenter_toolbench_recipe": {
//			   "description": "Fancier tools allow the carpenter to work with cloth and other civilized ingredients.",
//			   "recipe_name": "Carpenter Toolbench",
//			   "flavor": "A more elegant workstation, modeled on a more civilized time."
//			}
//		 }
//	  },
//	  "cook": {
//		 "cook_description": {
//			"display_name": "Cook",
//			"description": "The cook makes delicious, hearty meals from base vegetables and meats.",
//			"requirements": "2 levels of Farmer and a Stoneware Spoon, crafted by the Mason.",
//			"workshop": {
//			   "name": "Stone Cauldron",
//			   "long_description": "Humongous, heavy pot, suitable for cooking up a feast at a time!"
//			},
//			"level_6_data": {
//			   "title": "Master cook",
//			   "perk_000_name": "10,000 Hours (not implemented)",
//			   "perk_000_description": "The cook's dishes are now so good for you they have unexpected effects."
//			},
//			"level_2_data": {
//			   "perk_000_name": "Kitchen Chemistry",
//			   "perk_000_description": "The cook has learned to make slightly fancier recipes."
//			},
//			"level_4_data": {
//			   "perk_000_name": "Ingenuity Enhancements (not implemented)",
//			   "perk_000_description": "The cook adds new levels of functionality to classic recipes."
//			},
//			"level_1_data": {
//			   "perk_000_name": "Camp Cooking -- XXX TOM, REVISIT THE COOK PERKS!!!!!!",
//			   "perk_000_description": "The cook can make basic, nutritious recipes." 
//			},
//			"level_3_data": {
//			   "perk_000_name": "Artistic Inspiration",
//			   "perk_000_description": "When inspiration strikes, the cook may embellish his works in unexpected ways."
//			}
//		 },
//		 "cook_outfit": {
//			"display_name": "Cook Outfit",
//			"description": "Uniform for all cooks"
//		 },
//		 "cook_spoon": {
//			"display_name": "Cook's Spoon",
//			"description": "Used by the cook",
//			"cook_spoon_iconic": {
//			   "display_name": "Cook's Spoon",
//			   "description": "Required to promote a hearthling into a Cook."
//			},
//			"cook_spoon_talisman": {
//			   "display_name": "Cook's Spoon",
//			   "description": "Required to promote a hearthling into a Cook."
//			}
//		 },
//		 "cook_workbench": {
//			"cook_workbench_ghost": {
//			   "display_name": "Stone Cauldron",
//			   "description": "Used by the Cook for delicious recipes."
//			}
//		 },
//		 "recipes": {
//			"flour_recipe": {
//			   "description": "A necessary ingredient for all kinds of bread.",
//			   "recipe_name": "Sack of Flour"
//			},
//			"meat_stew_recipe": {
//			   "description": "Hearty, satisfying, and perfect to ease the passing of a cold night.",
//			   "recipe_name": "Savory Meat Stew",
//			   "flavor": "Before you ask, it's an assortment of meats."
//			},
//			"peasant_bread_recipe": {
//			   "description": "A crusty, basic bread.",
//			   "recipe_name": "Peasant Bread"
//			},
//			"food_name": "Food",
//			"ingredients_name": "Ingredients",
//			"veggie_stew_recipe": {
//			   "description": "A warm, savory broth, fortified with braised pumpkin!",
//			   "recipe_name": "Tasty Vegetable Stew",
//			   "flavor": "Afterwards, you feel satisfied, but not heavy."
//			},
//			"corn_bread_recipe": {
//			   "description": "A bread made from cornmeal.",
//			   "recipe_name": "Corn Bread",
//			   "flavor": "Like Ma used to make."
//			},
//			"poyo_pot_pie_recipe": {
//			   "description": "A tasty meat and veggie pie.",
//			   "recipe_name": "Poyo Pot Pie",
//			   "flavor": "Pie is always good."
//			},
//			"omelette_recipe": {
//			   "description": "Veggies and meat wrapped in egg.",
//			   "recipe_name": "Omelette",
//			   "flavor": "Part of a hearty breakfast"
//			},
//			"roast_poyo_recipe": {
//			   "description": "Slow roasted poyo meat",
//			   "recipe_name": "Roast Poyo",
//			   "flavor": "Put 'nother poyo on the barby."
//			},
//			"fried_eggs_recipe": {
//			   "description": "Eggs fried to order.",
//			   "recipe_name": "Fried Eggs",
//			   "flavor": "Do you like yours sunnyside up?"
//			},
//			"animal_feed_name": "Animal Feed",
//			"sheep_feed_recipe": {
//			   "description": "A supplement for a healthy sheep diet",
//			   "recipe_name": "Sheep Feed"
//			},
//			"poyo_feed_recipe": {
//			   "description": "For feeding one's poyos",
//			   "recipe_name": "Poyo Feed",
//			   "flavor": "Cluck cluck!"
//			},
//			"rabbit_feed_recipe": {
//			   "description": "Food for rabbits",
//			   "recipe_name": "Rabbit Feed"
//			},
//			"workbenches_name": "Workbenches",
//			"cook_workbench_recipe": {
//			   "description": "Use to cook nutritions soups and stews.",
//			   "recipe_name": "Stone Cauldron",
//			   "flavor": "Stone, to keep the food hot for a long time."
//			},
//			"cook_mill_recipe": {
//			   "description": "For grinding grains into flour",
//			   "recipe_name": "Stone Mill Grinder"
//			},
//			"cook_oven_recipe": {
//			   "description": "Great for roasting",
//			   "recipe_name": "Stone Oven"
//			}
//		 },
//		 "cook_mill": {
//			"cook_mill_ghost": {
//			   "display_name": "Stone Mill Grinder",
//			   "description": "Used by the cook to grind grains into flour."
//			}
//		 },
//		 "cook_oven": {
//			"cook_oven_ghost": {
//			   "display_name": "Stone Oven",
//			   "description": "Great for roasting"
//			}
//		 }
//	  },
//	  "engineer": {
//		 "engineer_description": {
//			"display_name": "???",
//			"description": "???",
//			"requirements": "???"
//		 }
//	  },
//	  "farmer": {
//		 "farmer_description": {
//			"display_name": "Farmer",
//			"description": "Farmers till fields and harvest crops, providing a consistent food supply and raw materials for baked goods.",
//			"requirements": "Farmer's Hoe, crafted by the Carpenter.",
//			"level_6_data": {
//			   "perk_000_name": "Nature's Surprise (not implemented)",
//			   "perk_000_description": "Occasionally, the farmer's special touch yields... special results."
//			},
//			"level_1_data": {
//			   "perk_000_name": "Speed Up 10%",
//			   "perk_000_description": "Running fresh food from field to table has increased the farmer's footspeed."
//			},
//			"level_2_data": {
//			   "perk_000_name": "Job Opportunities",
//			   "perk_000_description": "Exposure to fresh food has given the farmer ideas about cooked food. See the promotion menu for details."
//			},
//			"level_3_data": {
//			   "perk_000_name": "Bountiful Harvest",
//			   "perk_000_description": "The farmer coaxes greater yield from each plant."
//			}
//		 },
//		 "farmer_buffs": {
//			"speed_1_buff": {
//			   "description": "Running fresh food from field to table has increased the farmer's footspeed."
//			}
//		 },
//		 "farmer_hoe": {
//			"display_name": "Houe de fermier",
//			"description": "Utilisée pour labourer les champs.",
//			"farmer_hoe_iconic": {
//			   "display_name": "Houe de fermier",
//			   "description": "Requis pour promouvoir un hearthling en fermier."
//			},
//			"farmer_hoe_talisman": {
//			   "display_name": "Houe de fermier",
//			   "description": "Requis pour promouvoir un hearthling en fermier."
//			}
//		 },
//		 "farmer_outfit": {
//			"display_name": "Blouse de fermier",
//			"description": "Tenue standard pour tous les agriculteurs"
//		 },
//		 "field": {
//			"display_name": "Parcelle agricole",
//			"description": "Pour les cultures"
//		 }
//	  },
//	  "footman": {
//		 "footman_description": {
//			"display_name": "Footman",
//			"description": "The Footman is a melee fighter. A good choice for the backbone of your town's defense.",
//			"requirements": "Wooden Practice Sword, crafted by the Carpenter.",
//			"level_4_data": {
//			   "perk_000_name": "Damage Up 40%",
//			   "perk_000_description": "The footman is now practiced at optimizing the effect of each blow."
//			},
//			"level_1_data": {
//			   "perk_000_name": "Damage Up 20%",
//			   "perk_000_description": "The footman knows that all combats may have mortal consequences, and attacks with renewed determination."
//			},
//			"level_3_data": {
//			   "perk_000_name": "Power Spike",
//			   "perk_000_description": "This powerful, overhead swing deals double damage."
//			}
//		 },
//		 "footman_buffs": {
//			"damage_1_buff": {
//			   "description": "At Level 1, the footman attacks with increased ferocity"
//			},
//			"damage_2_buff": {
//			   "description": "At Level 1, the footman attacks with increased ferocity"
//			},
//			"damage_3_buff": {
//			   "description": "At Level 1, the footman attacks with increased ferocity"
//			}
//		 },
//		 "footman_outfit": {
//			"display_name": "Military Uniform",
//			"description": "Standard issue gear for all soldiers"
//		 }
//	  },
//	  "geomancer": {
//		 "geomancer_description": {
//			"display_name": "???",
//			"description": "???",
//			"requirements": "???"
//		 }
//	  },
//	  "hunter": {
//		 "hunter_description": {
//			"description": "???",
//			"requirements": "???"
//		 }
//	  },
//	  "mason": {
//		 "mason_description": {
//			"display_name": "Mason",
//			"description": "The Mason crafts building materials and decorative items from stone.",
//			"requirements": "Mason's Mallet and Chisel, crafted by the carpenter.",
//			"workshop": {
//			   "name": "Mason's Workshop",
//			   "description": "insert description here",
//			   "long_description": "The Mason crafts building materials and decorative items from stone."
//			},
//			"level_6_data": {
//			   "title": "Master mason",
//			   "perk_000_name": "10,000 Hours (not implemented)",
//			   "perk_000_description": "The mason's mastery of his trade allows him to come up with completely new ways of using wood."
//			},
//			"level_2_data": {
//			   "perk_000_name": "Fancy Rocks",
//			   "perk_000_description": "The mason can now make more elaborate items froms stone."
//			},
//			"level_4_data": {
//			   "perk_000_name": "Extended Catalog",
//			   "perk_000_description": "The mason ventures from the realm of the functional into... art."
//			},
//			"level_1_data": {
//			   "perk_000_name": "Standard Catalog",
//			   "perk_000_description": "The mason can now make a solid array of basic furniture."
//			},
//			"level_3_data": {
//			   "perk_000_name": "Artistic Inspiration",
//			   "perk_000_description": "When inspiration strikes, the mason may embellish his works in unexpected ways."
//			}
//		 },
//		 "mason_chisel": {
//			"display_name": "Mason's Chisel",
//			"description": "Tools of the trade for a mason.",
//			"mason_chisel_talisman": {
//			   "display_name": "Mason's Chisel",
//			   "description": "Required to promote a hearthling into a mason."
//			}
//		 },
//		 "mason_hammer": {
//			"display_name": "Mason's Hammer",
//			"description": "Tools of the trade for a mason."
//		 },
//		 "mason_outfit": {
//			"display_name": "Mason Smock",
//			"description": "Uniform for all masons"
//		 },
//		 "mason_workbench": {
//			"mason_workbench_ghost": {
//			   "display_name": "Mason Workbench",
//			   "description": "Used by the Mason for crafting."
//			}
//		 },
//		 "mason_pedestal": {
//			"mason_pedestal_ghost": {
//			   "display_name": "Mason Pedestal",
//			   "description": "Craft in a well-lit space."
//			}
//		 },
//		 "recipes": {
//			"bird_bath_recipe": {
//			   "description": "A decorative stone vase with water for the birdies.",
//			   "recipe_name": "Bird Bath",
//			   "flavor": "Not a chair."
//			},
//			"blacksmith_hammer_recipe": {
//			   "description": "Required to promote a hearthling into a Blacksmith.",
//			   "recipe_name": "Blacksmith's Hammer",
//			   "flavor": "From the dragon that lives in the forge, weapons and armor, defense and conquest."
//			},
//			"cobblestone_fence_gate_recipe": {
//			   "description": "It's thick stone walls grant a sense of security.",
//			   "recipe_name": "Cobblestone Fence Gate",
//			   "flavor": "Sheep go in, but can't get out!"
//			},
//			"cobblestone_fence_recipe": {
//			   "description": "A rustic, sturdy wall segment.",
//			   "recipe_name": "Cobblestone Fence",
//			   "flavor": "Use the earth itself to form the walls of the pasture? Genius!"
//			},
//			"cook_spoon_recipe": {
//			   "description": "Required to promote a hearthling into a Cook.",
//			   "recipe_name": "Cook's Spoon",
//			   "flavor": "COOKED FOOOOOOOOD!!!!!! --Alton The Bard"
//			},
//			"gargoyle_recipe": {
//			   "description": "Gothic-style carving to decorate your walls.",
//			   "recipe_name": "Wall Mounted Decorative Gargoyle",
//			   "flavor": "Remnants of the servants of Brelor, Crownless King."
//			},
//			"tools_name": "Tools",
//			"signage_decoration_name": "Signage & Decoration",
//			"building_parts_name": "Building Parts",
//			"weapons_name": "Weapons",
//			"furniture_name": "Furniture",
//			"stone_bench_recipe": {
//			   "description": "Outdoor seating for moments of relaxation.",
//			   "recipe_name": "Stone Bench",
//			   "flavor": "Pretty and functional. Matches the tombstones."
//			},
//			"stone_brazier_recipe": {
//			   "description": "A small fire pit that provides comfort and warmth at night.",
//			   "recipe_name": "Stone Brazier",
//			   "flavor": "Warning: Do not drop anything in while it's lit."
//			},
//			"stone_bricks_recipe": {
//			   "description": "A key component of stone structures like castles and roads.",
//			   "recipe_name": "Stack of Stone Bricks",
//			   "flavor": "Tis a lucky thing, boy, that the square is the natural shape within most rocks. --Garen Knapper"
//			},
//			"stone_chair_recipe": {
//			   "description": "Not horribly comforable, but a symbol of status.",
//			   "recipe_name": "Stone Chair",
//			   "flavor": "Outdoorsy!"
//			},
//			"stone_garden_lantern_recipe": {
//			   "description": "An ancient-looking lantern with great ambiance.",
//			   "recipe_name": "Stone Garden Lantern",
//			   "flavor": "Only slightly ominous looking."
//			},
//			"stone_maul_recipe": {
//			   "description": "The perfect tool for bludgeoning",
//			   "recipe_name": "Stone Maul",
//			   "flavor": "A modern adaptation of an ancient weapon."
//			},
//			"stone_table_recipe": {
//			   "description": "It's considerable weight gives it a sense of gravitas. For serious business only.",
//			   "recipe_name": "Stone Table",
//			   "flavor": "No lions were harmed in its construction."
//			},
//			"stone_wall_lantern_recipe": {
//			   "description": "Attaches to the walls of buildings, providing light",
//			   "recipe_name": "Stone Wall-mounted Lantern",
//			   "flavor": "Cons: Heavy. Pros: Unlikely to burn itself down."
//			},
//			"tower_brazier_recipe": {
//			   "description": "Fashioned after a castle tower, it provides a strong beacon at night.",
//			   "recipe_name": "Tower Brazier",
//			   "flavor": "Great for lining garden paths and intimidating guests."
//			},
//			"mason_workbench_recipe": {
//			   "description": "Required to produce most of the Mason's recipes.",
//			   "recipe_name": "Mason Workbench",
//			   "flavor": "Tappety-tap; Make the earth sing, Raise Brelor's ghost, Watch the mountain take wing."
//			},
//			"mason_pedestal_recipe": {
//			   "description": "A well lit place for creating stone artwork.",
//			   "recipe_name": "Mason's Pedestal",
//			   "flavor": "Snap and spark, hiss of coal, light the way, transmute the earth whole."
//			},
//			"workbenches_name": "Workbenches"
//		 }
//	  },
//	  "miner": {
//		 "miner_description": {
//			"display_name": "???",
//			"description": "???",
//			"requirements": "???"
//		 }
//	  },
//	  "shepherd": {
//		 "shepherd_description": {
//			"display_name": "Shepherd",
//			"description": "Domesticates wild animals and harvests them for food and materials.",
//			"requirements": "2 levels of Trapper and a Shepherd's Crook, crafted by the Carpenter.",
//			"level_4_data": {
//			   "perk_000_name": "Animal Magnetism",
//			   "perk_000_description": "Wild animals are more likely to appear whenever the shepherd is looking for them."
//			},
//			"level_1_data": {
//			   "perk_000_name": "Speed Up 10%",
//			   "perk_000_description": "The shepherd is now more adept at getting the flock to walk a tiny bit faster."
//			},
//			"level_3_data": {
//			   "perk_000_name": "Extra Bonuses",
//			   "perk_000_description": "The shepherd's skill produces greater yields in animal products."
//			}
//		 },
//		 "shepherd_crook": {
//			"display_name": "Shepherd's Crook",
//			"description": "Used to corral the flock",
//			"shepherd_crook_iconic": {
//			   "display_name": "Shepherd's Crook",
//			   "description": "Required to promote a hearthling into a Shepherd."
//			},
//			"shepherd_crook_talisman": {
//			   "display_name": "Shepherd's Crook",
//			   "description": "Required to promote a hearthling into a Shepherd."
//			}
//		 },
//		 "shepherd_outfit": {
//			"display_name": "Shepherd Outfit",
//			"description": "Uniform for all shepherds"
//		 },
//		 "shepherd_pasture": {
//			"display_name": "Animal Pasture",
//			"description": "Shepherds bring animals to these locations and tend to them here."
//		 }
//	  },
//	  "shield_bearer": {
//		 "shield_bearer_description": {
//			"display_name": "???",
//			"description": "???",
//			"requirements": "???"
//		 }
//	  },
//	  "trapper": {
//		 "trapper_description": {
//			"display_name": "Trapper",
//			"description": "The Trapper's snares capture and (ahem) &quot;harvest&quot; small critters for a reliable source of food and supplies.",
//			"requirements": "Trapper's Knife, forged by the Blacksmith",
//			"level_1_data": {
//			   "title": "Journeyman Trapper",
//			   "perk_000_name": "Speed Up 10%",
//			   "perk_000_description": "Long walks have increased the trapper's foot speed."
//			},
//			"level_3_data": {
//			   "perk_000_name": "Efficient Cuts",
//			   "perk_000_description": "Long practice helps the trapper salvage more from each animal."
//			},
//			"level_2_data": {
//			   "perk_000_name": "Charm Pet",
//			   "perk_001_name": "Job Opportunities",
//			   "perk_000_description": "The trapper will occasionally choose to turn a particulary fine animal into a pet!",
//			   "perk_001_description": "The trapper now qualifies for advanced jobs. Click the promote command for details."
//			},
//			"level_6_data": {
//			   "perk_000_name": "The Deadliest Catch (Not Implemented!)",
//			   "perk_000_description": "Lay special trapping zones to 'deter' acquisitive neighbors."
//			},
//			"level_5_data": {
//			   "perk_000_name": "Toothier Traps (Not implemented!)",
//			   "perk_000_description": "Traps now lure in and hold larger prey."
//			},
//			"level_4_data": {
//			   "perk_000_name": "Backpack Size +8",
//			   "perk_000_description": "The trapper has become more efficient at packing in the loot."
//			}
//		 },
//		 "snare_trap": {
//			"display_name": "Snare Trap",
//			"description": "Safely immobilizes its prey",
//			"commands": {
//			   "harvest_trapped_beast": {
//				  "display_name": "Harvest Beast",
//				  "description": "Slay the trapped beast and harvest him for materials!"
//			   },
//			   "tame_trapped_beast": {
//				  "display_name": "Tame Beast",
//				  "description": "Make friends! Befriend the trapped beast and make it your pet."
//			   }
//			}
//		 },
//		 "trapper_buffs": {
//			"speed_1_buff": {
//			   "description": "Long walks have increased the trapper's foot speed."
//			}
//		 },
//		 "trapper_knife": {
//			"display_name": "Couteau de trappeur",
//			"description": "Un couteau de trapper",
//			"trapper_knife_iconic": {
//			   "display_name": "Trapper's Knife",
//			   "description": "Basic trapper's knife."
//			},
//			"trapper_knife_talisman": {
//			   "display_name": "Trapper's Knife",
//			   "description": "Required to promote a hearthling into a Trapper."
//			}
//		 },
//		 "trapper_outfit": {
//			"display_name": "Trapper Oufit"
//		 },
//		 "trapping_grounds": {
//			"display_name": "Trapping Grounds",
//			"description": "Trappers catch critters for food and resources in this zone."
//		 }
//	  },
//	  "treasure_hunter": {
//		 "treasure_hunter_description": {
//			"display_name": "???",
//			"description": "???",
//			"requirements": "???"
//		 }
//	  },
//	  "weaponsmith": {
//		 "weaponsmith_description": {
//			"description": "???",
//			"requirements": "???"
//		 }
//	  },
//	  "weaver": {
//		 "weaver_description": {
//			"display_name": "Weaver",
//			"description": "The Weaver makes thread, fabrics and hangings from fiber and dye.",
//			"requirements": "Weaver's Spindle, crafted by the Carpenter.",
//			"workshop": {
//			   "name": "Weaver's Workshop",
//			   "long_description": "Makes thread and cloth!  Can't really have a respectable civilization without one!"
//			},
//			"level_6_data": {
//			   "title": "Master Weaver",
//			   "perk_000_name": "10,000 Hours (not implemented)",
//			   "perk_000_description": "The weaver's mastery of his trade allows him to come up with completely new ways of using wood."
//			},
//			"level_2_data": {
//			   "perk_000_name": "Collaborative Insight",
//			   "perk_000_description": "The weaver is now skillful enough to use materials created by other crafters."
//			},
//			"level_4_data": {
//			   "perk_000_name": "Ingenuity Enhancements (not implemented)",
//			   "perk_000_description": "The weaver adds new levels of functionality to classic recipes."
//			},
//			"level_1_data": {
//			   "perk_000_name": "Standard Catalog",
//			   "perk_000_description": "The weaver can now make basic hangings and decor."
//			},
//			"level_3_data": {
//			   "perk_000_name": "Artistic Inspiration",
//			   "perk_000_description": "When inspiration strikes, the weaver may embellish his works in unexpected ways."
//			}
//		 },
//		 "recipes": {
//			"banner_wall_big_recipe": {
//			   "description": "Show your town pride with this decorative banner.",
//			   "recipe_name": "Big Wall-Mounted Banner",
//			   "flavor": "Also a sign of affluence."
//			},
//			"banner_wall_small_recipe": {
//			   "description": "Show your town pride with this small banner.",
//			   "recipe_name": "Small Wall-Mounted Banner",
//			   "flavor": "Quality craftsmanship at fine resolutions."
//			},
//			"bolt_of_cloth_recipe": {
//			   "description": "Used to create more comfortable furniture.",
//			   "recipe_name": "Basic Bolt of Cloth",
//			   "flavor": "To make thicker by the width of one string: add string. Repeat 1,000,000 times."
//			},
//			"cloth_bolt_recipe": {
//			   "description": "Used to create more comfortable furniture.",
//			   "recipe_name": "Bolt of Cloth",
//			   "flavor": "To make thicker by the width of one string: add string. Repeat 1,000,000 times."
//			},
//			"cloth_padded_vest_recipe": {
//			   "description": "This triple-quilted vest provides more protection to your combat units than mere clothing. Not a lot more, but every little bit helps, right?",
//			   "recipe_name": "Padded Vest",
//			   "flavor": "Needs... thicker... padding!"
//			},
//			"curtains_recipe": {
//			   "description": "Dresses up an otherwise ordinary window.",
//			   "recipe_name": "Pretty Curtains",
//			   "flavor": "Light-blocking technology encourages sleeping-in."
//			},
//			"fur_rug_recipe": {
//			   "description": "A warm and cozy rug, sewn from various animal pelts.",
//			   "recipe_name": "Fur Rug",
//			   "flavor": "Perfect for an evening by the fire."
//			},
//			"leather_bolt_recipe": {
//			   "description": "Prepared sheets of leather, ready to be put to good use.",
//			   "recipe_name": "Bolt of Leather",
//			   "flavor": "You can hardly see the individual sources."
//			},
//			"leather_vest_recipe": {
//			   "description": "Hardened leather provides study protection against light weapons.",
//			   "recipe_name": "Thick Leather Vest",
//			   "flavor": "Insults bounce right off too!"
//			},
//			"plushie_toy_rabbit_recipe": {
//			   "description": "A toy... for children of course.",
//			   "recipe_name": "Plushie Toy Rabbit",
//			   "flavor": "She loves you!"
//			},
//			"clothing_armor_name": "Clothing & Armor",
//			"toys_name": "Toys",
//			"decorations_name": "Decorations",
//			"crafting_materials_name": "Crafting Materials",
//			"spool_of_thread_recipe": {
//			   "description": "Needed for cloth. Warm and fluffy",
//			   "recipe_name": "Spool of Thread",
//			   "flavor": "Each gram of fiber yearns to become a sweater."
//			},
//			"tapestry_wall_recipe": {
//			   "description": "A decorative scene, woven in colored thread and cord.",
//			   "recipe_name": "Wall-Mounted Tapestry",
//			   "flavor": "What you see in its knotted depths tells you something about yourself."
//			},
//			"thread_recipe": {
//			   "description": "Needed for cloth. Warm and fluffy",
//			   "recipe_name": "Spool of Thread",
//			   "flavor": "Each gram of fiber yearns to become a sweater."
//			},
//			"throw_rug_recipe": {
//			   "description": "Brightens up that old dusty floor.",
//			   "recipe_name": "Decorative Throw Rug",
//			   "flavor": "Too beautiful to step on."
//			},
//			"worker_outfit_2_recipe": {
//			   "description": "Double stiching and strategically placed padding improves the worker's efficiency. The worker who dons this upgrade outfit will move 10% faster.",
//			   "recipe_name": "Upgraded Worker Outfit",
//			   "flavor": "Your town loves you!"
//			},
//			"worker_outfit_winter_recipe": {
//			   "description": "A heavy wool coat, for cold winter nights. The worker who dons this upgrade outfit will move 10% faster.",
//			   "recipe_name": "Winter Worker Outfit",
//			   "flavor": "Winter is coming!"
//			},
//			"workbenches_name": "Workbenches",
//			"weaver_loom_recipe": {
//			   "description": "Add thread to thread till cloth results.",
//			   "recipe_name": "Loom",
//			   "flavor": "Patient Spider, weaver, writer, draws the tapestry of fate tighter. --Rayya's Rhyme"
//			},
//			"weaver_spinning_wheel_recipe": {
//			   "description": "Spins prickly, scratchy, chaos into thread.",
//			   "recipe_name": "Spinning Wheel",
//			   "flavor": "Spider smiles; all eight eyes glitter, 'Something from nothing, some sweet and some bitter.'"
//			},
//			"weaver_workbench_recipe": {
//			   "description": "Used to make complex crafts of thread and fabric.",
//			   "recipe_name": "Weaver Workbench",
//			   "flavor": "In the beginning there was nothing, and then there was Spider."
//			}
//		 },
//		 "weaver_loom": {
//			"weaver_loom_ghost": {
//			   "display_name": "Loom",
//			   "description": "A skilled Weaver uses this to weave thread into cloth."
//			}
//		 },
//		 "weaver_outfit": {
//			"display_name": "Weaver Outfit",
//			"description": "Uniform for all weavers"
//		 },
//		 "weaver_spindle": {
//			"display_name": "The Spindle",
//			"description": "For spinning fiber into thread",
//			"weaver_spindle_iconic": {
//			   "display_name": "The Spindle",
//			   "description": "For spinning fiber into thread"
//			},
//			"weaver_spindle_talisman": {
//			   "display_name": "The Spindle",
//			   "description": "For spinning fiber into thread"
//			}
//		 },
//		 "weaver_spinning_wheel": {
//			"weaver_spinning_wheel_ghost": {
//			   "display_name": "Spinning Wheel",
//			   "description": "A skilled Weaver uses this to spin fiber into thread."
//			}
//		 },
//		 "weaver_workbench": {
//			"weaver_workbench_ghost": {
//			   "display_name": "Weaver Workbench",
//			   "description": "Used by the Weaver for crafting."
//			}
//		 }
//	  },
//	  "worker": {
//		 "worker_description": {
//			"display_name": "Worker",
//			"description": "Workers perform basic tasks like harvesting resources, hauling stuff around, and constructing buildings.",
//			"requirements": "None, just hard work and guts.",
//			"level_0_data": {
//			   "title": "Worker"
//			}
//		 },
//		 "winter_worker_outfit": {
//			"display_name": "Winter Worker Outfit",
//			"description": "A heavy wool coat, for cold winter nights",
//			"winter_worker_outfit_iconic": {
//			   "display_name": "Winter Worker Outfit",
//			   "description": "So warm..."
//			}
//		 },
//		 "worker_outfit": {
//			"display_name": "Worker Outfit",
//			"description": "Uniform for all workers"
//		 },
//		 "worker_outfit_2": {
//			"display_name": "Upgraded Worker Outfit",
//			"description": "Reinforced construction improves worker efficiency!",
//			"worker_outfit_2_iconic": {
//			   "display_name": "Upgraded Worker Outfit",
//			   "description": "Sturdy construction increases workers' productivity"
//			}
//		 }
//	  }
//   },
//   "stonehearth_mixins": {
//	  "base_human": {
//		 "display_name": "[str(self.unit_info.custom_name)]",
//		 "description": "Citizen of your town",
//		 "job": {
//			"starting_level_title": "Apprentice [str(self.stonehearth:job.curr_job_name)]",
//			"default_level_title": "Level [str(self.stonehearth:job.curr_job_level)] [str(self.stonehearth:job.curr_job_name)]",
//			"default_level_announcement": "[name(i18n_data.entity)] has achieved [str(i18n_data.job_name)] Level [str(i18n_data.level_number)]!",
//			"general_description_desc": "Max health increased!",
//			"attribute_up_desc": "All attributes increased!"
//		 }
//	  },
//	  "food": {
//		 "food_decay": {
//			"food_decay": {
//			   "decay_1": {
//				  "description": "Starting to Rot. Better eat it fast."
//			   },
//			   "decay_2": {
//				  "description": "Rotten. Ew."
//			   }
//			}
//		 },
//		 "jerky": {
//			"display_name": "Jerky",
//			"description": "Stringy, but nutritious!"
//		 }
//	  },
//	  "monster": {
//		 "job": {
//			"starting_level_title": "Apprentice [str(self.stonehearth:job.curr_job_name)]",
//			"default_level_title": "Level [str(self.stonehearth:job.curr_job_level)] [str(self.stonehearth:job.curr_job_name)]",
//			"default_level_announcement": "[name(i18n_data.entity)] has achieved [str(i18n_data.job_name)] Level [str(i18n_data.level_number)]!",
//			"general_description_desc": "Max Health increased!",
//			"attribute_up_desc": "All attributes increased!"
//		 }
//	  },
//	  "resources": {
//		 "fur_pelt": {
//			"display_name": "Fur pelt",
//			"description": "Soft, supple, and quite dead"
//		 }
//	  }
//   }
//}