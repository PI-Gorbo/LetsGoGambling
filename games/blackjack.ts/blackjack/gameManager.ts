import { ranks, suits, type Actor, type BlackjackGame, type BlackjackGameAction, type Deck, type PlayingCard } from "./types"

export function createDeck(): Deck {
    const cards = suits
        .flatMap(suit => ranks.map(rank => ({ suit, rank })))
        .map(({ suit, rank }): PlayingCard => ({
            suit,
            rank
        }))

    return {
        cards
    }
}

export function shuffleDeck(deck: Deck): Deck {
    throw new Error("Not Implemented")
}

export function createNewGame(): BlackjackGame {
    throw new Error("Not Implemented")
}
type PerformActionResult = {
    kind: 'success'
    updatedGame: BlackjackGame
} | {
    kind: 'invalidAction',
    error: string
}

export function performAction(game: BlackjackGame, action: BlackjackGameAction): PerformActionResult {
    throw new Error("Not Implemented")
}

export function isGameComplete(game: BlackjackGame): boolean {
    throw new Error("Not Implemented")
}

export function getCurrentActor(gameState: BlackjackGame): Actor {
    throw new Error("Not Implemented")
}