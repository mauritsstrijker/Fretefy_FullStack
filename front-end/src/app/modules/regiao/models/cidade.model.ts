import { Entity } from "src/app/shared/models/entity.model";

export interface Cidade extends Entity {
  nome: string;
  uf: string;
}