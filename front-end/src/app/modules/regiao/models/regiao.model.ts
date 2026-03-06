import { Entity } from "src/app/shared/models/entity.model";
import { Cidade } from "./cidade.model";

export interface Regiao extends Entity {
  nome: string;
  status: string;
  cidades: Cidade[];
}