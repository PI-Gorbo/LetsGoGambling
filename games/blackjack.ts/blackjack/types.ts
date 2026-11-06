
export const suits = ["Hearts", "Spades", "Clubs", "Diamonds"] as const
export type Suit = (typeof suits)[number]

export const ranks = ["Ace", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King"] as const
export type Rank = (typeof ranks)[number]

export type PlayingCard = {
    suit: Suit,
    rank: Rank
}

export type Deck = {
    cards: PlayingCard[]
}

export type BlackjackGame = {}

type PileNumber = number
type PileNumberAction = {
    pileNumber: PileNumber
}
export type HitAction = {
    kind: "hit"
} & PileNumberAction
export type StandAction = {
    kind: "stand"
}
export type SplitAction = {
    kind: "split"
} & PileNumberAction
export type DoubleDown = {
    kind: 'doubleDown',
} & PileNumberAction

export type Player = { kind: 'player', name: string }
export type Dealer = { kind: 'dealer' }
export type Actor =
    | Player
    | Dealer

export type BlackjackGameAction =
    | HitAction
    | StandAction
    | SplitAction
    | DoubleDown

